using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosPuestos
    {
        void Borrar(int puestoId);
        bool EstaRelacionado(Puesto puesto);
        bool Existe(Puesto puesto);
        int GetCantidad();
        Puesto GetPuestoPorId(int puestoId);
        List<Puesto> GetPuestoPorPagina(int registrosPorPagina, int paginaActual);
        List<Puesto> GetPuestos();
        void Guardar(Puesto puesto);
    }
}
