using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosEmpleados
    {
        void Borrar(int empleadoId);
        bool EstaRelacionado(Empleado empleado);
        bool Existe(Empleado empleado);
        int GetCantidad();
        int GetCantidad(int? empleadoId);
        List<EmpleadoDto> GetEmpleado(int? PuestoId, int? SectorId);
        Empleado GetEmpleadoPorId(int empleadoId);
        List<EmpleadoDto> GetEmpleadoPorPagina(int registrosPorPagina, int paginaActual, int? PuestoId);
        void Guardar(Empleado empleado);
    }
}
