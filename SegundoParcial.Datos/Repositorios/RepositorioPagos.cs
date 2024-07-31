using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public void Agregar(Pago pago)
        {
            string insertQuery = @"INSERT INTO pagos(EmpleadoId,Fecha, EstadoPago,AsistenciaId,ImporteTotal)
                                    VALUES (@EmpleadoId, @Fecha,@EstadoPago,@AsistenciaId,@ImporteTotal); 
                                   SELECT SCOPE_IDENTITY()";

            int ID = transaction.Connection.QuerySingle<int>(insertQuery, pago, transaction: transaction);
            pago.PagoId = ID;
            GuardarItemDetallePago(pago);
        }

        private void GuardarItemDetallePago(Pago pago)
        {
            try
            {
                string insertQuery = @"INSERT INTO ItemsDetallePago (PagoId, Fecha, Sueldo, Total)
                               VALUES (@PagoId, @Fecha, @Sueldo, @Total); SELECT SCOPE_IDENTITY()";

                double sueldo = pago.ImporteTotal;
                double total = pago.ImporteTotal * 1.1;
                int itemDetallePagoId = transaction.Connection.QuerySingle<int>(insertQuery, new
                {
                    PagoId = pago.PagoId,
                    Fecha = pago.Fecha,
                    Sueldo = sueldo,
                    Total = total
                }, transaction: transaction);
                ItemsDetallePago itemsDetallePago = new ItemsDetallePago();
                itemsDetallePago.ItemDetallePagoId = itemDetallePagoId;
                GuardarDetallePago(itemsDetallePago, pago);
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }

        private void GuardarDetallePago(ItemsDetallePago detallepago, Pago pago)
        {
            try
            {
                string insertQuery = @"INSERT INTO DetallePagos(ItemDetallePagoId,PagoId,EmpleadoId,ImporteTotal)
                               VALUES (@ItemDetallePagoId,@PagoId,@EmpleadoId,@ImporteTotal)";
                transaction.Connection.Execute(insertQuery, new
                {
                    ItemDetallePagoId = detallepago.ItemDetallePagoId,
                    PagoId = pago.PagoId,
                    EmpleadoId = pago.EmpleadoId,
                    ImporteTotal = pago.ImporteTotal
                }, transaction: transaction);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }

        public void Borrar(int pagoId)
        {
            string deleteQuery = "DELETE FROM Pagos WHERE PagoId=@PagoId";
            transaction.Connection.Execute(deleteQuery, new { PagoId = pagoId }, transaction: transaction);
        }


        public bool EstaRelacionado(Pago pago)
        {
            int cantidad = 0;
            string selectQuery = "SELECT COUNT(*) FROM DetallePagos WHERE PagoId=@PagoId";
            cantidad = transaction.Connection.QuerySingle<int>(selectQuery, new { PagoId = pago.PagoId }, transaction: transaction);
            return cantidad > 0;
        }

        public int GetCantidad(int? empleadoId)
        {
            int cantidad = 0;
            string selectQuery;
            if (empleadoId == null)
            {
                selectQuery = "SELECT COUNT(*) FROM Pagos ";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, transaction: transaction);
            }
            else
            {
                selectQuery = @"SELECT COUNT(*) FROM Pagos WHERE empleadoId=@empleadoId";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery,
                    new { empleadoId = empleadoId }, transaction: transaction);
            }
            return cantidad;
        }

        public List<PagoListDto> GetPago()
        {
            List<PagoListDto> lista = new List<PagoListDto>();

            string selectQuery = @"SELECT e.Nombre, pt.SueldoPorHora,p.PagoId,e.Dni,p.Fecha,p.AsistenciaId,p.ImporteTotal,e.Dni
                                   FROM Pagos p INNER JOIN Empleados e ON p.EmpleadoId = e.empleadoId
                                   INNER JOIN Puestos pt ON e.PuestoId = pt.PuestoId
                                   ORDER BY p.PagoId,e.Nombre";
            lista = transaction.Connection.Query<PagoListDto>(selectQuery, transaction: transaction).ToList();
            return lista;
        }



        public PagoListDto GetPagoPorId(int PagoId)
        {
            string selectQuery = @"SELECT p.PagoId,e.Nombre,p.Fecha,EstadoPago,pt.SueldoPorHora,pt.NombrePuesto,e.empleadoId,
                                   p.ImporteTotal,e.Dni FROM Pagos p inner join Empleados e on e.empleadoId=p.EmpleadoId
								   inner join Puestos pt on e.PuestoId=pt.PuestoId  where p.PagoId=@PagoId";
            var pagoListDto = transaction.Connection.QuerySingle<PagoListDto>(selectQuery,
          new { @PagoId = PagoId }, transaction: transaction);
            return pagoListDto;
        }


        public Pago GetPagosPorId(int pagoId)
        {
            Pago pago = null;
            string selectQuery = @" SELECT p.PagoId, e.nombre,Fecha,EstadoPago,e.Dni,p.AsistenciaId,p.ImporteTotal,e.empleadoId,pt.SueldoPorHora
                                   FROM Pagos p inner join empleados e on p.EmpleadoId=e.empleadoId
								inner join Puestos pt on e.PuestoId=pt.PuestoId WHERE p.PagoId=@PagoId";
            pago = transaction.Connection.QuerySingleOrDefault<Pago>(selectQuery,
                new { PagoId = pagoId }, transaction: transaction);
            return pago;
        }

        public List<PagoListDto> GetPagosPorPagina(int cantidad, int pagina, int? empleadoid)
        {
            List<PagoListDto> listaPago = new List<PagoListDto>();
            if (empleadoid == null)
            {
                string selectQuery = @"SELECT p.PagoId, e.Nombre,pt.SueldoPorHora,p.Fecha,e.empleadoId,pt.NombrePuesto,
                                       p.ImporteTotal,p.EstadoPago 
									   FROM pagos p INNER JOIN Empleados e ON p.EmpleadoId = e.empleadoId
                                       INNER JOIN Asistencias a ON p.AsistenciaId = a.AsistenciaId
                                       INNER JOIN  Puestos pt ON e.PuestoId = pt.PuestoId
                                        ORDER BY p.PagoId,e.Nombre
                                       OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
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

                string selectQuery = @"SELECT p.PagoId, e.Nombre,pt.SueldoPorHora,p.Fecha,e.empleadoId,pt.NombrePuesto,
                                       p.ImporteTotal,p.EstadoPago 
									   FROM pagos p INNER JOIN Empleados e ON p.EmpleadoId = e.empleadoId
                                       INNER JOIN Asistencias a ON p.AsistenciaId = a.AsistenciaId
                                       INNER JOIN  Puestos pt ON e.PuestoId = pt.PuestoId
                                      where e.EmpleadoId = @EmpleadoId
 
                                        ORDER BY p.PagoId,e.Nombre
                                       OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var registroSeteados = cantidad * (pagina - 1);

                listaPago = transaction.Connection.Query<PagoListDto>(selectQuery,
                new
                {
                    empleadoid = empleadoid.Value,
                    cantidadRegistros = registroSeteados,
                    cantidadPorPagina = cantidad
                }, transaction: transaction).ToList();
            }
            transaction.Commit();
            return listaPago;
        }

        public void AgregarDetalles(Pago pago)
        {
            string insertDetalleQuery = @"INSERT INTO ItemsDetallePago(ItemDetallePagoId,HorasTrabajadas,
                                          HorasExtras, Descuentos, SueldoPorHora, Jubilacion, ObraSocial, PagoId)
                                         VALUES(@ItemDetallePagoId,@HorasTrabajadas, @HorasExtras, @Descuentos,
                                         @SueldoPorHora, @Jubilacion,@ObraSocial, @PagoId); SELECT SCOPE_IDENTITY()";
            int ID = transaction.Connection.QuerySingle<int>(insertDetalleQuery, pago, transaction: transaction);
            pago.PagoId = ID;
        }

        public void Editar(Asistencia asistencia, Pago pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                using (var transaction = unitOfWork.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = @"UPDATE Pagos SET  Fecha = @Fecha,EmpleadoId=@EmpleadoId,
                       ImporteTotal = (a.HorasTrabajadas * pt.SueldoPorHora * 0.90)
                       FROM  Pagos p INNER JOIN Asistencias a ON p.AsistenciaId = a.AsistenciaId
                       INNER JOIN Empleados e ON p.EmpleadoId = e.EmpleadoId
                       INNER JOIN Puestos pt ON e.PuestoId = pt.PuestoId
                       WHERE  p.AsistenciaId = @AsistenciaId";
                        transaction.Connection.Execute(updateQuery, pago, transaction: transaction);

                        transaction.Commit();
                        EditarItemsDetallPago(asistencia, pago);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al editar el pago", ex);
                    }
                }
            }
        }

        private void EditarItemsDetallPago(Asistencia asistencia, Pago pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {

                try
                {
                    string updateItemsDetallePagoQuery = @"UPDATE ItemsDetallePago SET Sueldo = p.ImporteTotal / 0.90, 
                                                           Total = p.ImporteTotal
                                                          FROM ItemsDetallePago idp INNER JOIN Pagos p ON 
                                                          idp.PagoId = p.PagoId
                                                          WHERE p.AsistenciaId = @AsistenciaId";
                    transaction.Connection.Execute(updateItemsDetallePagoQuery, new { AsistenciaId = asistencia.AsistenciaId }
                    , transaction: transaction);
                    DetallePagos detallePagos = new DetallePagos();
                    EditarDetallPago(asistencia);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al editar la asistencia", ex);
                }
            }
        }

        private void EditarDetallPago(Asistencia asistencia)
        {
            try
            {
                string updateDetallePagosQuery = @"UPDATE DetallePagos SET ImporteTotal = p.ImporteTotal
                                                   FROM DetallePagos dp INNER JOIN ItemsDetallePago idp 
                                                   ON dp.ItemDetallePagoId = idp.ItemDetallePagoId
                                                   INNER JOIN Pagos p ON idp.PagoId = p.PagoId
                                                   WHERE p.AsistenciaId = @AsistenciaId";
                transaction.Connection.Execute(updateDetallePagosQuery, new { AsistenciaId = asistencia.AsistenciaId}
                , transaction: transaction);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Error al editar detalle del pago", ex);
            }
        }

        public void PagarAEmpleado(PagoListDto pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                using (var transaction = unitOfWork.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = @"UPDATE Pagos SET EstadoPago=1 WHERE pagoId=@pagoId";
                        transaction.Connection.Execute(updateQuery, new{ pagoId = pago.PagoId}, transaction: transaction);
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        public void Editar(Pago pago)
        {
            string updateQuery = @"update Pagos set EmpleadoId=@EmpleadoId,Fecha=@Fecha,
              ImporteTotal=@ImporteTotal,EstadoPago=@EstadoPago, AsistenciaId=@AsistenciaId where PagoId=@PagoId";
            transaction.Connection.Execute(updateQuery, pago, transaction: transaction);

        }

        public void AnularPago(PagoListDto pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                using (var transaction = unitOfWork.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = @"UPDATE Pagos SET EstadoPago=3 WHERE pagoId=@pagoId";
                        transaction.Connection.Execute(updateQuery, new { pagoId = pago.PagoId }, transaction: transaction);
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
