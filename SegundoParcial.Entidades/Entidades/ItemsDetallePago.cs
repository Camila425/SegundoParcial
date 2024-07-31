using System;

namespace SegundoParcial.Entidades.Entidades
{
    public class ItemsDetallePago
    {

        public int ItemDetallePagoId { get; set; }
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public double Sueldo { get; set; }
        public double ToTal { get; set; }

    }
}
