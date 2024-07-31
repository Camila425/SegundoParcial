using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
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
  
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void Editar(Asistencia asistencia)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                if (asistencia.AsistenciaId != 0)
                {
                    unitOfWork.Asistencia.Editar(asistencia);

                }
            }
        }

        public bool Existe(Asistencia asistencia)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Asistencia.Existe(asistencia);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
