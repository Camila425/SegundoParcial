using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosSectores : IServiciosSectores
    {
        public ServiciosSectores()
        {
        }

        public void Borrar(int sectorId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    unitOfWork.Sectores.Borrar(sectorId);
                    unitOfWork.Commit();
                }
                catch (Exception)
                {
                    unitOfWork?.Rollback();
                    throw;
                } 
            }
        }

        public bool EstaRelacionado(Sector sector)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Sectores.EstaRelacionado(sector);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public bool Existe(Sector sector)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Sectores.Existe(sector);
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
                    return unitOfWork.Sectores.GetCantidad();
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<Sector> GetSectores()
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Sectores.GetSectores();
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<Sector> GetSectorPorPagina(int registrosPorPagina, int paginaActual)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    var lista = unitOfWork.Sectores.GetSectorPorPagina(registrosPorPagina, paginaActual);
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public void Guardar(Sector sector)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    if (sector.SectorId == 0)
                    {
                        unitOfWork.Sectores.Agregar(sector);
                    }
                    else
                    {
                        unitOfWork.Sectores.Editar(sector);
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
