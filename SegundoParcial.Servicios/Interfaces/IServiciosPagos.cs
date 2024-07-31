using SegundoParcial.Entidades.Dtos.PagoDetalleDto;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosPagos
    {
        void AnularPago(PagoListDto pago);
        void Borrar(int pagoId);
        void Editar(Asistencia asistencia, Pago pago);
        void Editar(Pago pago);
        bool EstaRelacionado(Pago pago);
        int GetCantidad(int? empleadoId);
        List<PagoListDto> GetPago();
        PagoDetalleDto GetPagoDetalle(int pagoId);

         PagoListDto GetPagoPorId(int pagoId);
        Pago GetPagosPorId(int pagoId);

        List<PagoListDto> GetPagosPorPagina(int registrosPorPagina, int paginaActual,int? empleado);
        void Guardar(Pago pago);
        void PagarAEmpleado(PagoListDto pago);
    }
}
