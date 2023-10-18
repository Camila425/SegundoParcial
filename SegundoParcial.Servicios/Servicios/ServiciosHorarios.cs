using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.Horarios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosHorarios:IServiciosHorarios
    {
        private readonly IRepositorioHorario repositorio;
        public ServiciosHorarios()
        {
            repositorio = new RepositorioHorarios();
        }

        public void Borrar(int horarioId)
        {
            try
            {
                repositorio.Borrar(horarioId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Existe(Horario horario)
        {
            try
            {
                return repositorio.Existe(horario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Horario GetHorarioPorId(int horarioId)
        {
            try
            {
                return repositorio.GetHorarioPorId(horarioId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<HorarioDto> GetHorarios(int? TipoDeHorarioId)
        {
            try
            {
                return repositorio.GetHorarios( TipoDeHorarioId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TipoDeHorario> GetTipoHorarios()
        {
            try
            {
                return repositorio.GetTipoHorarios();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Guardar(Horario horario)
        {
            try
            {
                if (horario.HorarioId == 0)
                {
                    repositorio.Agregar(horario);
                }
                else
                {
                    repositorio.Editar(horario);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
