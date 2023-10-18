using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosEmpleados : IServiciosEmpleados
    {
        private readonly IRepositorioEmpleado repositorio;
        public ServiciosEmpleados()
        {
            repositorio = new RepositorioEmpleados();
        }

        public void Borrar(int empleadoId)
        {
            try
            {
                repositorio.Borrar(empleadoId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EstaRelacionado(Empleado empleado)
        {
            try
            {
                return repositorio.EstaRelacionado(empleado);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Existe(Empleado empleado)
        {
            try
            {
                return repositorio.Existe(empleado);
            }
            catch (Exception)
            {
                throw;
            }
        }

       

        public int GetCantidad()
        {
            try
            {
                return repositorio.GetCantidad();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int GetCantidad(int? PuestoId)
        {
            try
            {
                return repositorio.GetCantidad(PuestoId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<EmpleadoDto> GetEmpleado(int? PuestoId, int? SectorId)
        {
            try
            {
                return repositorio.GetEmpleado(PuestoId,SectorId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Empleado GetEmpleadoPorId(int empleadoId)
        {
            try
            {
                return repositorio.GetEmpleadoPorId(empleadoId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<EmpleadoDto> GetEmpleadoPorPagina(int registrosPorPagina, int paginaActual, int? PuestoId)
        {
            try
            {
                var lista= repositorio.GetEmpleadoPorPagina(registrosPorPagina, paginaActual,PuestoId);
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

       
        public void Guardar(Empleado empleado)
        {
            try
            {
                if (empleado.EmpleadoId==0)
                {
                    repositorio.Agregar(empleado);
                }
                else
                {
                    repositorio.Editar(empleado);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
