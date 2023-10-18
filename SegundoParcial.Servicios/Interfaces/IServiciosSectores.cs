using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosSectores
    {
        void Borrar(int sectorId);
        bool EstaRelacionado(Sector sector);
        bool Existe(Sector sector);
        List<Sector> GetSectores();
        void Guardar(Sector sector);
    }
}
