using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosAsistencias : IServiciosAsistencias
    {

        private readonly IRepositorioAsistencia repositorio;
        public ServiciosAsistencias()
        {
            repositorio = new RepositorioAsistencias();
        }

        public void Borrar(int asistenciaId)
        {
            try
            {
                repositorio.Borrar(asistenciaId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Asistencia GetAsistenciaPorId(int asistenciaId)
        {
            try
            {
                return repositorio.GetAsistenciaPorId(asistenciaId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<AsistenciaDto> GetAsistenciaPorPagina(int registrosPorPagina, int paginaActual, int? EmpleadoId)
        {

            try
            {
                var lista = repositorio.GetAsistenciaPorPagina(registrosPorPagina, paginaActual,EmpleadoId);
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<AsistenciaDto> GetAsistencias(int? EmpleadoId)
        {
            try
            {
                return repositorio.GetAsistencias(EmpleadoId);
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

        public void Guardar(Asistencia asistencia)
        {
            try
            {
                if (asistencia.AsistenciaId==0)
                {
                    repositorio.Agregar(asistencia);
                }
                else
                {
                    repositorio.Editar(asistencia);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
