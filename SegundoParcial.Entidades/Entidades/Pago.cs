using SegundoParcial.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades.Entidades
{
    public class Pago
    {
        public int PagoId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public EstadoPago estado { get; set; }
    }
}
