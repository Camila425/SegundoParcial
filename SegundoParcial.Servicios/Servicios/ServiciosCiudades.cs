using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosCiudades : IServiciosCiudades
    {
        public ServiciosCiudades()
        {
        }

        public void Borrar(int ciudadId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    unitOfWork.Ciudad.Borrar(ciudadId);
                    unitOfWork.Commit();
                }
                catch (Exception)
                {
                    unitOfWork?.Rollback();
                    throw;
                }
            }
        }

        public bool EstaRelacionada(Ciudad ciudad)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Ciudad.EstaRelacionada(ciudad);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public bool Existe(Ciudad ciudad)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Ciudad.Existe(ciudad);
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
                    return unitOfWork.Ciudad.GetCantidad();
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<Ciudad> GetCiudades()
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Ciudad.GetCiudades();
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<Ciudad> GetCiudadesPorPagina(int cantidad, int paginaActual)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Ciudad.GetCiudadesPorPagina(cantidad, paginaActual);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public void Guardar(Ciudad ciudad)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    if (ciudad.CiudadId == 0)
                    {
                        unitOfWork.Ciudad.Agregar(ciudad);
                    }
                    else
                    {
                        unitOfWork.Ciudad.Editar(ciudad);
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
