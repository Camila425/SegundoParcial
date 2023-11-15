using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.Horarios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosHorarios:IServiciosHorarios
    {
        public ServiciosHorarios()
        {
        }

        public void Borrar(int horarioId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    unitOfWork.Horario.Borrar(horarioId);
                    unitOfWork.Commit();
                }
                catch (Exception)
                {
                    unitOfWork?.Rollback();
                    throw;
                } 
            }
        }

        public bool Existe(Horario horario)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Horario.Existe(horario);
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
                    return unitOfWork.Horario.GetCantidad();
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public Horario GetHorarioPorId(int horarioId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Horario.GetHorarioPorId(horarioId);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<HorarioDto> GetHorarioPorPagina(int registrosPorPagina, int paginaActual,int? TipoHorario)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    var lista = unitOfWork.Horario.GetHorarioPorPagina(registrosPorPagina, paginaActual, TipoHorario);
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<HorarioDto> GetHorarios(int? TipoDeHorarioId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Horario.GetHorarios(TipoDeHorarioId);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<TipoDeHorario> GetTipoHorarios()
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {

                try
                {
                    return unitOfWork.Horario.GetTipoHorarios();
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public void Guardar(Horario horario)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    if (horario.HorarioId == 0)
                    {
                        unitOfWork.Horario.Agregar(horario);
                    }
                    else
                    {
                        unitOfWork.Horario.Editar(horario);
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
