using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Entidades.Enums;
using System;

namespace SegundoParcial.Entidades.Dtos.Asistencias
{
    public class AsistenciaDto:ICloneable
    {
        public int AsistenciaId { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public Estados Estado { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
