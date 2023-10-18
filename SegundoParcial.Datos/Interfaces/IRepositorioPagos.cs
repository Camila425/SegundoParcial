using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioPagos
    {
        void Agregar(Pago pago);
        void Editar(Pago pago);
        List<PagoDto> GetPago(int? EmpleadoId);
    }
}
