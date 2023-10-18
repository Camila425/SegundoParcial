using SegundoParcial.Entidades.Dtos.Horarios;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosHorarios
    {
        void Borrar(int horarioId);
        bool Existe(Horario horario);
        Horario GetHorarioPorId(int horarioId);
        List<HorarioDto> GetHorarios(int? TipoDeHorarioId);
        List<TipoDeHorario> GetTipoHorarios();
        void Guardar(Horario horario);
    }
}
