using System;

namespace SegundoParcial.Entidades.Entidades
{
    public class Asistencia:ICloneable
    {
        public int AsistenciaId { get; set; }
        public int empleadoId { get; set; }
        public int PagoId { get; set; }
        public int HorasTrabajadas { get; set; }
        public int ItemDetallePagoId { get; set; }
        public double SueldoPorHora { get; set; }
        public double HorasExtras { get; set; }
        public double Descuentos { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan? HoraSalida { get; set; }
        public double ImporteTotal => Math.Floor((SueldoPorHora * HorasTrabajadas - Descuentos) + (HorasExtras * PrecioXHorasExtras));
        public double PrecioXHorasExtras { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
