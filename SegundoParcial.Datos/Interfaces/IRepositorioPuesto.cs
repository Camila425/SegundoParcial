using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioPuesto
    {
        void Agregar(Puesto puesto);
        void Borrar(int puestoId);
        void Editar(Puesto puesto);
        bool Existe(Puesto puesto);
        int GetCantidad();
        List<Puesto> GetPuestoPorPagina(int registrosPorPagina, int paginaActual);
        Puesto GetPuestoPorId(int puestoId);
        List<Puesto> GetPuestos();
        bool EstaRelacionado(Puesto puesto);
    }
}
