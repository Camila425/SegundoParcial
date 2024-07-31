using SegundoParcial.Entidades.Dtos.ItemsDetallePago;
using SegundoParcial.Entidades.Dtos.Pagos;
using System.Collections.Generic;

namespace SegundoParcial.Entidades.Dtos.PagoDetalleDto
{
    public class PagoDetalleDto
    {
        public PagoListDto pagoListDto { get; set; }
        public List<ItemsDetallePagoDto> DetallesDto{ get; set; }

    }
}
