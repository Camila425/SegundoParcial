using SegundoParcial.Entidades.Enums;
using System;

namespace SegundoParcial.Entidades.Dtos.Pagos
{
    public class PagoListDto:ICloneable
    {
        public int PagoId { get; set; }
        public int EmpleadoId { get; set; }

        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public double SueldoPorHora { get; set; }
        public EstadoPago estadoPago { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public string NombrePuesto { get; set; }
        public int HorasTrabajadas { get; set; }
        public double ImporteTotal { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
