using SegundoParcial.Entidades.Entidades;
using System;

namespace SegundoParcial.Entidades.Dtos.ItemsDetallePago
{
    public class ItemsDetallePagoDto
    {
        public int ItemDetallePagoId { get; set; }
        public int pagoid { get; set; }
        public double SueldoPorHora { get; set; }
        public double HorasTrabajadas { get; set; }
        public double HorasExtras { get; set; }
        public string Descuentos
        {
            get
            {
                return "10%";
            }
        }
        public double ImporteTotal { get; set; }
        
        public double Sueldo { get; set; }

        public Asistencia asistencias { get; set; } = new Asistencia();
        public string NombrePuesto { get; set; }
        public int Asistenciaid { get; set; }
        public double PrecioXHorasExtras { get; set; }
        public string Nombre { get; set; }
        public DateTime fecha { get; set; }


    }
}
