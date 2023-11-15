using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosPagos
    {
        void Borrar(int pagoId);
        bool EstaRelacionado(PagoListDto pago);
        int GetCantidad(int? empleadoId);
        PagoDetalleDto GetPagoDetalle(int PagoId);
        List<PagoListDto> GetPago(int? EmpleadoId);
        PagoListDto GetPagoPorId(int pagoId);
        Pago GetPagosPorId(int pagoId);

        List<PagoListDto> GetPagosPorPagina(int registrosPorPagina, int paginaActual,int? empleado);
        void Guardar(Pago pago);
    }
}
