using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosSectores
    {
        void Borrar(int sectorId);
        bool EstaRelacionado(Sector sector);
        bool Existe(Sector sector);
        int GetCantidad();
        List<Sector> GetSectores();
        List<Sector> GetSectorPorPagina(int registrosPorPagina, int paginaActual);
        void Guardar(Sector sector);
    }
}
