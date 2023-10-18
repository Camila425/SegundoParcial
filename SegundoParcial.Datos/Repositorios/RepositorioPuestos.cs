using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioPuestos : IRepositorioPuesto
    {
        private readonly string CadenaConexion;
        public RepositorioPuestos()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Puesto puesto)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string insertQuery = "INSERT INTO Puestos(NombrePuesto,Sueldo) VALUES(@NombrePuesto,@Sueldo); SELECT SCOPE_IDENTITY()";
                int ID = conn.QuerySingle<int>(insertQuery, puesto);
                puesto.PuestoId = ID;
            }
        }

        public void Borrar(int puestoId)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string deleteQuery = "DELETE FROM Puestos WHERE PuestoId=@PuestoId";
                conn.Execute(deleteQuery, new { puestoId=puestoId });
            }
        }

        public void Editar(Puesto puesto)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string updateQuery = "update Puestos SET NombrePuesto=@NombrePuesto,Sueldo=@Sueldo WHERE PuestoId=@PuestoId";
                conn.Execute(updateQuery, puesto);
            }
        }

        public bool Existe(Puesto puesto)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (puesto.PuestoId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Puestos WHERE NombrePuesto=@NombrePuesto";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, puesto);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Puestos WHERE NombrePuesto=@NombrePuesto AND PuestoId!=@PuestoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, puesto);
                }
            }
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {

                string selectQuery = "SELECT COUNT(*) FROM Puestos";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }

        public List<Puesto> GetPuestoPorPagina(int cantidad, int pagina)
        {
            List<Puesto> listapuesto = new List<Puesto>();
            using (var conn = new SqlConnection(CadenaConexion))
            {

                string selectQuery = @"SELECT PuestoId, NombrePuesto, Sueldo FROM Puestos
                    ORDER BY NombrePuesto
                    OFFSET @cantidadRegistros ROWS 
                    FETCH NEXT @cantidadPorPagina ROWS ONLY";

                 listapuesto = conn.Query<Puesto>(selectQuery,
                 new
                 {
                   cantidadRegistros = (pagina - 1) * cantidad,
                   cantidadPorPagina = cantidad
                 }).ToList();
            }
            return listapuesto;
        }

        public Puesto GetPuestoPorId(int puestoId)
        {
            Puesto puesto = null;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = @"SELECT PuestoId,NombrePuesto,Sueldo FROM Puestos WHERE PuestoId=@PuestoId";
                puesto = conn.QuerySingleOrDefault<Puesto>(selectQuery, new { puestoId = puestoId });
            }
            return puesto;
        }

        public List<Puesto> GetPuestos()
        {
            List<Puesto> lista = new List<Puesto>();
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = "select PuestoId,NombrePuesto,Sueldo from Puestos order by NombrePuesto";
                lista = conn.Query<Puesto>(selectQuery).ToList();
            }
            return lista;
        }

        public bool EstaRelacionado(Puesto puesto)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Empleados WHERE PuestoId=@PuestoId";
                cantidad = conn.QuerySingle<int>(selectQuery, new { PuestoId = puesto.PuestoId });
            }
            return cantidad > 0;
        }
    }
}
