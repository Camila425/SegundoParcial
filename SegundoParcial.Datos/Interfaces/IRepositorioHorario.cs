﻿using SegundoParcial.Entidades.Dtos.Horarios;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioHorario
    {
        void Agregar(Horario horario);
        void Borrar(int horarioId);
        void Editar(Horario horario);
        bool Existe(Horario horario);
        Horario GetHorarioPorId(int horarioId);
        List<HorarioDto> GetHorarios(int? TipoDeHorarioId);
        List<TipoDeHorario> GetTipoHorarios();
    }
}
