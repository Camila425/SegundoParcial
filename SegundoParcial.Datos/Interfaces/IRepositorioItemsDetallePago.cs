using SegundoParcial.Entidades.Dtos.ItemsDetallePago;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioItemsDetallePago
    {
        List<ItemsDetallePagoDto> GetItemsDetallePago(int PagoId);
        ItemsDetallePagoDto GetItemsDetallePagoId(int itemsueldoId);
    }
}
