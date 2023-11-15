using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosPuestos : IServiciosPuestos
    {
        public ServiciosPuestos()
        {
        }

        public void Borrar(int puestoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    unitOfWork.Puesto.Borrar(puestoId);
                    unitOfWork.Commit();
                }
                catch (Exception)
                {
                    unitOfWork?.Rollback();
                    throw;
                } 
            }
        }

        public bool EstaRelacionado(Puesto puesto)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Puesto.EstaRelacionado(puesto);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public bool Existe(Puesto puesto)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    bool existe= unitOfWork.Puesto.Existe(puesto);
                    return existe;
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
                    var cantidad= unitOfWork.Puesto.GetCantidad();
                    return cantidad;
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public Puesto GetPuestoPorId(int puestoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Puesto.GetPuestoPorId(puestoId);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<Puesto> GetPuestoPorPagina(int registrosPorPagina, int paginaActual)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    var  lista=unitOfWork.Puesto.GetPuestoPorPagina(registrosPorPagina, paginaActual);
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<Puesto> GetPuestos()
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    var Lista= unitOfWork.Puesto.GetPuestos();
                    return Lista;
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public void Guardar(Puesto puesto)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    if (puesto.PuestoId == 0)
                    {
                        unitOfWork.Puesto.Agregar(puesto);
                    }
                    else
                    {
                        unitOfWork.Puesto.Editar(puesto);
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
