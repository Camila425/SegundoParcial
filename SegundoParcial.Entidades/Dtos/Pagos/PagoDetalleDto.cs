using SegundoParcial.Entidades.Dtos.DetallePgo;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Entidades.Dtos.Pagos
{
    public class PagoDetalleDto
    {
        public PagoListDto pagoListDto { get; set; }
        public List<DetallePagoDto> DetallesDto{ get; set; }
    }
}
