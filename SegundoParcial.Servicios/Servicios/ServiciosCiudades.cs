using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosCiudades : IServiciosCiudades
    {
        private readonly IRepositorioCiudad repositorio;
        public ServiciosCiudades()
        {
            repositorio = new RepositorioCiudades();
        }

        public void Borrar(int ciudadId)
        {
            try
            {
                repositorio.Borrar(ciudadId);
            }
            catch (Exception)
            {
                throw;
            }        
        }

        public bool EstaRelacionada(Ciudad ciudad)
        {
            try
            {
                return repositorio.EstaRelacionada(ciudad);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Existe(Ciudad ciudad)
        {
            try
            {
                return repositorio.Existe(ciudad);
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

        public List<Ciudad> GetCiudades()
        {
            try
            {
                return repositorio.GetCiudades();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Ciudad> GetCiudadesPorPagina(int cantidad, int paginaActual)
        {
            try
            {
                return repositorio.GetCiudadesPorPagina(cantidad, paginaActual);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Guardar(Ciudad ciudad)
        {
            try
            {
                if (ciudad.CiudadId == 0)
                {
                    repositorio.Agregar(ciudad);
                }
                else
                {
                    repositorio.Editar(ciudad);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
