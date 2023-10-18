using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioEmpleado
    {
        void Agregar(Empleado empleado);
        void Borrar(int empleadoId);
        void Editar(Empleado empleado);
        bool EstaRelacionado(Empleado empleado);
        bool Existe(Empleado empleado);
        int GetCantidad();
        int GetCantidad(int? empleadoId);
        List<EmpleadoDto> GetEmpleado( int? PuestoId, int? SectorId);
        Empleado GetEmpleadoPorId(int empleadoId);
        List<EmpleadoDto> GetEmpleadoPorPagina(int registrosPorPagina, int paginaActual, int? PuestoId);
    }
}
