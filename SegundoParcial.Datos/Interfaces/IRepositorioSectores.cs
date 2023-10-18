using SegundoParcial.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioSectores
    {
        void Agregar(Sector sector);
        void Borrar(int sectorId);
        void Editar(Sector sector);
        bool EstaRelacionado(Sector sector);
        bool Existe(Sector sector);
        List<Sector> GetSectores();
    }
}
