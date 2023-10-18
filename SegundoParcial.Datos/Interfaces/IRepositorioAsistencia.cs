using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioAsistencia
    {
        void Agregar(Asistencia asistencia);
        void Borrar(int asistenciaId);
        void Editar(Asistencia asistencia);
        Asistencia GetAsistenciaPorId(int asistenciaId);
        List<AsistenciaDto> GetAsistenciaPorPagina(int registrosPorPagina, int paginaActual, int? EmpleadoId);
        List<AsistenciaDto> GetAsistencias(int? EmpleadoId);
        int GetCantidad();
    }
}
