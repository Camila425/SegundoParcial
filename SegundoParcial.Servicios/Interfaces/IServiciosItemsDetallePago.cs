using SegundoParcial.Entidades.Dtos.ItemsDetallePago;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosItemsDetallePago
    {
        List<ItemsDetallePagoDto> GetItemsSueldo(int pagoid);
        ItemsDetallePagoDto GetItemSueldoPorId(int ItemsSueldoid);


    }
}
