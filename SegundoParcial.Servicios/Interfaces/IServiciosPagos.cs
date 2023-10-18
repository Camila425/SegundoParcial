using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosPagos
    {
        List<PagoDto> GetPago(int? EmpleadoId);
        void Guardar(Pago pago);
    }
}
