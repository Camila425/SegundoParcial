using SegundoParcial.Entidades.Enums;
using System;

namespace SegundoParcial.Entidades.Entidades
{
    public class Pago
    {
        public int PagoId { get; set; }
        public int ItemDetallePagoId { get; set; }
        public double ImporteTotal { get; set; }
        public string Nombre { get; set; }
        public double PrecioXHorasExtras { get; set; }
        public int EmpleadoId { get; set; }
        public double SueldoPorHora { get; set; }
        public double HorasExtras { get; set; }
        public int HorasTrabajadas { get; set; }
        public double CantHorasExtras { get; set; }
        public double Descuentos { get; set; }
        public int AsistenciaId { get; set; }
        public DateTime Fecha { get; set; }
        public EstadoPago EstadoPago { get; set; }
      
    }
}
