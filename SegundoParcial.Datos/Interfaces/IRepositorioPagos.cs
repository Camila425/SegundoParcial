using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioPagos
    {
        void Agregar(Pago pago);
        void Borrar(int pagoId);
        void Editar(Pago pago);
        bool EstaRelacionado(PagoListDto pago);
        int GetCantidad(int? empleadoId);
        List<PagoListDto> GetPago(int? EmpleadoId);
        PagoListDto GetPagoPorId(int pagoId);
        Pago GetPagosPorId(int pagoId);
        List<PagoListDto> GetPagosPorPagina(int registrosPorPagina, int paginaActual,int? empleadoId);
        double GetSueldoPorHora(int empleadoId);
    }
}
