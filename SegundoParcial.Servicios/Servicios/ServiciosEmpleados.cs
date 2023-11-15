using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosEmpleados : IServiciosEmpleados
    {
        public ServiciosEmpleados()
        {
        }

        public void Borrar(int empleadoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    unitOfWork.Empleado.Borrar(empleadoId);
                    unitOfWork.Commit();
                }
                catch (Exception)
                {
                    unitOfWork?.Rollback();
                    throw;
                }
            }
        }

        public bool EstaRelacionado(Empleado empleado)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Empleado.EstaRelacionado(empleado);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public bool Existe(Empleado empleado)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {

                try
                {
                    return unitOfWork.Empleado.Existe(empleado);
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
                    return unitOfWork.Empleado.GetCantidad();
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public int GetCantidad(int? PuestoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Empleado.GetCantidad(PuestoId);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<EmpleadoDto> GetEmpleado(int? PuestoId, int? SectorId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Empleado.GetEmpleado(PuestoId, SectorId);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public Empleado GetEmpleadoPorId(int empleadoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.Empleado.GetEmpleadoPorId(empleadoId);
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

        public List<EmpleadoDto> GetEmpleadoPorPagina(int registrosPorPagina, int paginaActual, int? PuestoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    var lista = unitOfWork.Empleado.GetEmpleadoPorPagina(registrosPorPagina, paginaActual, PuestoId);
                    return lista;
                }
                catch (Exception)
                {
                    throw;
                } 
            }
        }

       
        public void Guardar(Empleado empleado)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    if (empleado.EmpleadoId == 0)
                    {
                        unitOfWork.Empleado.Agregar(empleado);
                    }
                    else
                    {
                        unitOfWork.Empleado.Editar(empleado);
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
