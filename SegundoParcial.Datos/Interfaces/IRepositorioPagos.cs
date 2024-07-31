using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioPagos
    {
        void Agregar(Pago pago);
        void AgregarDetalles(Pago pago);
        void AnularPago(PagoListDto pago);
        void Borrar(int pagoId);
        void Editar(Asistencia asistencia, Pago pago);
        void Editar(Pago pago);
        bool EstaRelacionado(Pago pago);
        int GetCantidad(int? empleadoId);
        List<PagoListDto> GetPago();
        PagoListDto GetPagoPorId(int pagoId);
        Pago GetPagosPorId(int pagoId);
        List<PagoListDto> GetPagosPorPagina(int registrosPorPagina, int paginaActual,int? empleadoId);
        void PagarAEmpleado(PagoListDto pago);
    }
}
