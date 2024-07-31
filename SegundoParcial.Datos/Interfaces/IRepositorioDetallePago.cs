using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioDetallePago
    {
        List<ItemsDetallePago> GetItemsDetallePago(int pagoId);
    }
}
