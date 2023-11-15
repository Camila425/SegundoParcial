using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioSectores
    {
        void Agregar(Sector sector);
        void Borrar(int sectorId);
        void Editar(Sector sector);
        bool EstaRelacionado(Sector sector);
        bool Existe(Sector sector);
        int GetCantidad();
        List<Sector> GetSectores();
        List<Sector> GetSectorPorPagina(int registrosPorPagina, int paginaActual);
    }
}
