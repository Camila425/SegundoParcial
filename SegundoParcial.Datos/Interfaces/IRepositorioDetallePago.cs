using SegundoParcial.Entidades.Dtos.DetallePgo;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioDetallePago
    {
        List<DetallePagoDto> GetDetallePago(int pagoId);
    }
}
