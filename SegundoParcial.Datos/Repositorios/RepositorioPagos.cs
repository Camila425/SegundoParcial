using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioPagos : IRepositorioPagos
    {
        private readonly IDbTransaction transaction;
        public RepositorioPagos(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }
        public void Editar(Pago pago)
        {
            string updateQuery = @"update Pagos SET EmpleadoId=@EmpleadoId,Fecha=@Fecha,Importe=@Importe
                                   WHERE PagoId=@PagoId";
            transaction.Connection.Execute(updateQuery, pago, transaction: transaction);
        }

        public void Agregar(Pago pago)
        {
            try
            {
                string insertQuery = @"INSERT INTO Pagos(EmpleadoId, Fecha, Importe, EstadoPago)
                               VALUES(@EmpleadoId, @Fecha, @Importe, @EstadoPago); SELECT SCOPE_IDENTITY()";
                int ID = transaction.Connection.QuerySingle<int>(insertQuery, pago, transaction: transaction);
                pago.PagoId = ID;

                pago.Detalles.Add(new DetallePagos
                {
                    DetallePagoId=pago.DetallePagoId,
                    PagoId = pago.PagoId,
                    Importe = pago.CalcularImporte()
                }) ;

                foreach (var detalle in pago.Detalles)
                {
                    detalle.DetallePagoId = pago.DetallePagoId;
                    detalle.PagoId = pago.PagoId;
                    AgregarDetallePago(pago.PagoId, detalle);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void AgregarDetallePago(int pagoId, DetallePagos detalle)
        {
            try
            {
                string insertQuery = @"INSERT INTO DetallePagos(PagoId, Importe)
                           VALUES(@PagoId, @Importe); SELECT SCOPE_IDENTITY()";

                detalle.PagoId = pagoId;

                transaction.Connection.Execute(insertQuery, detalle, transaction: transaction);
            }
            catch ( Exception)
            {

                throw;
            }
        }


        public void Borrar(int pagoId)
        {
            string deleteQuery = "DELETE FROM Pagos WHERE PagoId=@PagoId";
            transaction.Connection.Execute(deleteQuery, new { PagoId = pagoId }, transaction: transaction);
        }

     
        public bool EstaRelacionado(PagoListDto pago)
        {
            int cantidad = 0;
            string selectQuery = "SELECT COUNT(*) FROM DetallePagos WHERE PagoId=@PagoId";
            cantidad = transaction.Connection.QuerySingle<int>(selectQuery, new { PagoId = pago.PagoId }, transaction: transaction);
            return cantidad > 0;
        }

        public int GetCantidad(int? empleadoId)
        {
            int cantidad = 0;
            string selectQuery = "select count (*)  from pagos";
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, transaction: transaction);

            return cantidad;
        }

        public List<PagoListDto> GetPago(int? EmpleadoId)
        {
            List<PagoListDto> lista = new List<PagoListDto>();
            string selectQuery;
            if (EmpleadoId == null)
            {
                selectQuery = @"SELECT e.Nombre, SUM(SueldoPorHora)
                                        FROM Pagos p inner join Empleados e on p.EmpleadoId=e.empleadoId
                                        GROUP BY e.Nombre
									    ORDER by e.Nombre";
                lista = transaction.Connection.Query<PagoListDto>(selectQuery, transaction: transaction).ToList();
            }
            else
            {
                selectQuery = @"SELECT e.Nombre, SUM(SueldoPorHora)
                                       FROM Pagos p inner join Empleados e on p.EmpleadoId=e.empleadoId
                                        GROUP BY e.Nombre
									    ORDER by e.Nombre";
                lista = transaction.Connection.Query<PagoListDto>(selectQuery,
                 new { EmpleadoId = EmpleadoId }, transaction: transaction).ToList();
            }

            return lista;
        }



        public PagoListDto GetPagoPorId(int PagoId)
        {
            string selectQuery = @"SELECT PagoId, e.nombre,Fecha,p.Importe,EstadoPago,e.Dni
                                       FROM Pagos p inner join empleados e on p.EmpleadoId=e.empleadoId
									    WHERE PagoId=@PagoId";
            var pagoListDto = transaction.Connection.QuerySingle<PagoListDto>(selectQuery,
          new { @PagoId = PagoId }, transaction: transaction);
            return pagoListDto;
        }

        public Pago GetPagosPorId(int pagoId)
        {
            string selectQuery = @"SELECT PagoId, e.nombre,Fecha,p.Importe,EstadoPago,e.Dni
                                       FROM Pagos p inner join empleados e on p.EmpleadoId=e.empleadoId
									    WHERE PagoId=@PagoId";
            var pagoListDto = transaction.Connection.QuerySingle<Pago>(selectQuery,
          new { @PagoId = pagoId }, transaction: transaction);
            return pagoListDto;
        }

        public List<PagoListDto> GetPagosPorPagina(int cantidad, int pagina, int? empleadoid)
        {
            List<PagoListDto> listaPago = new List<PagoListDto>();
            if (empleadoid == null)
            {
                string selectQuery = @"SELECT e.Nombre, SueldoPorHora,PagoId,e.Dni,p.Fecha
                                       FROM Pagos p
                                      INNER JOIN Empleados e ON p.EmpleadoId = e.empleadoId
                                      INNER JOIN Puestos pt ON e.PuestoId = pt.PuestoId
                                      ORDER BY e.Nombre
                                     OFFSET @cantidadRegistros ROWS 
                                     FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var registroSeteados = cantidad * (pagina - 1);
                listaPago = transaction.Connection.Query<PagoListDto>(selectQuery,
                new
                {
                    cantidadRegistros = registroSeteados,
                    cantidadPorPagina = cantidad,

                }, transaction: transaction).ToList();
            }
            else
            {
                string selectQuery = @"SELECT e.Nombre, SueldoPorHora,PagoId,e.Dni,p.Fecha
                                       FROM Pagos p
                                      INNER JOIN Empleados e ON p.EmpleadoId = e.empleadoId
                                      INNER JOIN Puestos pt ON e.PuestoId = pt.PuestoId
                                      where e.EmpleadoId = @EmpleadoId and pt.PuestoId = @PuestoId
                                      ORDER BY e.Nombre
                                     OFFSET @cantidadRegistros ROWS 
                                     FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var registroSeteados = cantidad * (pagina - 1);


                listaPago = transaction.Connection.Query<PagoListDto>(selectQuery,
                new
                {
                    empleadoid = empleadoid.Value,
                    cantidadRegistros = registroSeteados,
                    cantidadPorPagina = cantidad
                }, transaction: transaction).ToList();
            }
            return listaPago;
        }

        public double GetSueldoPorHora(int empleadoId)
        {
            string selectQuery = @"SELECT SUM(p.SueldoPorHora*a.HorasTrabajadas) as sueldoPorHora 
                FROM Asistencias a inner join Empleados e  on a.empleadoId=e.empleadoId
				                   inner join Puestos p on e.PuestoId=p.PuestoId
				 WHERE e.empleadoId=@empleadoId";
            var SueldoPorHora = transaction.Connection.ExecuteScalar<double>(selectQuery,
                new { @empleadoId }, transaction: transaction);

            return SueldoPorHora;
        }
    }
}
