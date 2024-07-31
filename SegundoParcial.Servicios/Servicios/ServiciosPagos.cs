using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.PagoDetalleDto;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosPagos : IServiciosPagos
    {
        public ServiciosPagos()
        {

        }

        public void Borrar(int pagoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    unitOfWork.Pagos.Borrar(pagoId);
                    unitOfWork.Commit();
                }
                catch (Exception)
                {
                    unitOfWork?.Rollback();
                    throw;
                }
            }
        }

        public bool EstaRelacionado(Pago pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Pagos.EstaRelacionado(pago);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int GetCantidad(int? empleadoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Pagos.GetCantidad(empleadoId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<PagoListDto> GetPago()
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Pagos.GetPago();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }



        public List<PagoListDto> GetPagosPorPagina(int registrosPorPagina, int paginaActual, int? empleado)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    var lista = unitOfWork.Pagos.GetPagosPorPagina(registrosPorPagina, paginaActual, empleado);
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Guardar(Pago pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    unitOfWork.Pagos.Agregar(pago);
                }
                catch (Exception)
                {
                    unitOfWork.Rollback();
                    unitOfWork.Dispose();
                }
            }
        }

        public Pago GetPagosPorId(int pagoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Pagos.GetPagosPorId(pagoId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public PagoDetalleDto GetPagoDetalle(int pagoId)
        {
            PagoDetalleDto ItemDetalleDto = new PagoDetalleDto();
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    ItemDetalleDto.pagoListDto = unitOfWork.Pagos.GetPagoPorId(pagoId);
                    ItemDetalleDto.DetallesDto = unitOfWork.ItemsDetallePago.GetItemsDetallePago(pagoId);
                    return ItemDetalleDto;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public PagoListDto GetPagoPorId(int pagoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Pagos.GetPagoPorId(pagoId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Editar(Asistencia asistencia, Pago pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                if (asistencia.AsistenciaId != 0)
                {
                    unitOfWork.Pagos.Editar(asistencia,pago);

                }
            }
        }

        public void PagarAEmpleado(PagoListDto pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            { 
               unitOfWork.Pagos.PagarAEmpleado(pago);
            }
        }

        public void Editar(Pago pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                if (pago.PagoId != 0)
                {
                    unitOfWork.Pagos.Editar(pago);
                }
                unitOfWork.Commit();

            }
        }

        public void AnularPago(PagoListDto pago)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                unitOfWork.Pagos.AnularPago(pago);
            }
        }
    }
}
