using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosPuestos : IServiciosPuestos
    {
        private readonly IRepositorioPuesto repositorio;
        public ServiciosPuestos()
        {
            repositorio = new RepositorioPuestos();
        }

        public void Borrar(int puestoId)
        {
            try
            {
                repositorio.Borrar(puestoId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EstaRelacionado(Puesto puesto)
        {
            try
            {
                return repositorio.EstaRelacionado(puesto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Existe(Puesto puesto)
        {
            try
            {
                return repositorio.Existe(puesto);
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

        public Puesto GetPuestoPorId(int puestoId)
        {
            try
            {
                return repositorio.GetPuestoPorId(puestoId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Puesto> GetPuestoPorPagina(int registrosPorPagina, int paginaActual)
        {
            try
            {
                return repositorio.GetPuestoPorPagina(registrosPorPagina, paginaActual);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Puesto> GetPuestos()
        {
            try
            {
                return repositorio.GetPuestos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Guardar(Puesto puesto)
        {
            try
            {
                if (puesto.PuestoId == 0)
                {
                    repositorio.Agregar(puesto);
                }
                else
                {
                    repositorio.Editar(puesto);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
