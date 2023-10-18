using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioPagos:IRepositorioPagos
    {
        private readonly string CadenaConexion;
        public RepositorioPagos()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Pago pago)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string insertQuery = @"INSERT INTO Pagos(EmpleadoId,Fecha,Importe,Estado)
                                     VALUES(@EmpleadoId,@Fecha,@Importe,@Estado); SELECT SCOPE_IDENTITY()";
                int ID = conn.QuerySingle<int>(insertQuery, pago);
                pago.PagoId = ID;
            }
        }

        public void Editar(Pago pago)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string updateQuery = @"update Pagos SET EmpleadoId=@EmpleadoId,Fecha=@Fecha,Importe=@Importe,Estado=@Estado
                                       WHERE PagoId=@PagoId";
                conn.Execute(updateQuery, pago);
            }
        }

        public List<PagoDto> GetPago(int? EmpleadoId)
        {
            List<PagoDto> lista = new List<PagoDto>();
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (EmpleadoId==null )
                {
                    selectQuery = @"select p.PagoId,e.Nombre,p.Fecha,Importe,Estado
                                    from Empleados e inner join  Pagos p on e.empleadoId=p.EmpleadoId";
                    lista = conn.Query<PagoDto>(selectQuery).ToList();
                }
                else
                {
                    selectQuery = @"select p.PagoId,e.Nombre,p.Fecha,Importe,Estado
                                    from Empleados e inner join  Pagos p on e.empleadoId=p.EmpleadoId";
                    lista = conn.Query<PagoDto>(selectQuery, new { EmpleadoId=EmpleadoId}).ToList();
                }
            }
            return lista;
        }


    }
}
