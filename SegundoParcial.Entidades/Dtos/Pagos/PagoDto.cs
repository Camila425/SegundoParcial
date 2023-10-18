using SegundoParcial.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades.Dtos.Pagos
{
    public class PagoDto
    {
        public int PagoId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public EstadoPago estadoPago { get; set; }
    }
}
