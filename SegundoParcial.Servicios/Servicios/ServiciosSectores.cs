using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosSectores : IServiciosSectores
    {
        private readonly IRepositorioSectores repositorio;
        public ServiciosSectores()
        {
            repositorio = new RepositorioSectores();
        }

        public void Borrar(int sectorId)
        {
            try
            {
                repositorio.Borrar(sectorId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EstaRelacionado(Sector sector)
        {
            try
            {
                return repositorio.EstaRelacionado(sector);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Existe(Sector sector)
        {
            try
            {
                return repositorio.Existe(sector);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Sector> GetSectores()
        {
            try
            {
                return repositorio.GetSectores();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Guardar(Sector sector)
        {
            try
            {
                if (sector.SectorId == 0)
                {
                    repositorio.Agregar(sector);
                }
                else
                {
                    repositorio.Editar(sector);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
