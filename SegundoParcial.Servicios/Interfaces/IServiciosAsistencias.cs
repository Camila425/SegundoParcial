﻿using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosAsistencias
    {
        void Borrar(int asistenciaId);
        void Editar(Asistencia asistencia);
        bool Existe(Asistencia asistencia);
        Asistencia GetAsistenciaPorId(int asistenciaId);
        List<AsistenciaDto> GetAsistenciaPorPagina(int registrosPorPagina, int paginaActual, int? EmpleadoId);
        List<AsistenciaDto> GetAsistencias(int? EmpleadoId);
        int GetCantidad();
        int GetCantidad(int? empleadoId);
        void Guardar(Asistencia asistencia);
    }
}
