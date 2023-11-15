using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Entidades.Enums;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosAsistencias : IServiciosAsistencias
    {

        public ServiciosAsistencias()
        {
        }

        public void Borrar(int asistenciaId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    unitOfWork.Asistencia.Borrar(asistenciaId);
                    unitOfWork.Commit();
                }
                catch (Exception)
                {
                    unitOfWork?.Rollback();
                    throw;
                }
            }
        }

        public Asistencia GetAsistenciaPorId(int asistenciaId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Asistencia.GetAsistenciaPorId(asistenciaId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<AsistenciaDto> GetAsistenciaPorPagina(int registrosPorPagina, int paginaActual, int? EmpleadoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    var lista = unitOfWork.Asistencia.GetAsistenciaPorPagina(registrosPorPagina, paginaActual, EmpleadoId);
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<AsistenciaDto> GetAsistencias(int? EmpleadoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Asistencia.GetAsistencias(EmpleadoId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public int GetCantidad()
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Asistencia.GetCantidad();
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
                    return unitOfWork.Asistencia.GetCantidad(empleadoId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Guardar(Asistencia asistencia)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {

                try
                {

                    if (asistencia.AsistenciaId == 0)
                    {
                        unitOfWork.Asistencia.Agregar(asistencia);
                    }

                    AgregarPagoYDetalles(unitOfWork, asistencia);

                    unitOfWork.Commit();
                }
                catch (Exception)
                {
                    unitOfWork.Rollback();
                    unitOfWork.Dispose();
                }


            }
        }

        private void AgregarPagoYDetalles(UnitOfWork unitOfWork, Asistencia asistencia)
        {
            var SueldoPorHora = unitOfWork.Pagos.GetSueldoPorHora(asistencia.empleadoId);
            var pago = new Pago()
            {

                EmpleadoId = asistencia.empleadoId,
                Fecha = DateTime.Now,
                Importe = SueldoPorHora,
                EstadoPago = EstadoPago.Impago
            };

            unitOfWork.Pagos.Agregar(pago);
        }

        public void Editar(Asistencia asistencia)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    if (asistencia.AsistenciaId != 0)
                    {
                        unitOfWork.Asistencia.Editar(asistencia);
                    }

                    unitOfWork.Commit();
                }
                catch (Exception)
                {
                    unitOfWork.Rollback();
                    unitOfWork.Dispose();
                }
            }
        }

     
    }
}
