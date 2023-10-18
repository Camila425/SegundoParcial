using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioCiudad
    {
        void Agregar(Ciudad ciudad);
        void Borrar(int ciudadId);
        void Editar(Ciudad ciudad);
        bool EstaRelacionada(Ciudad ciudad);
        bool Existe(Ciudad ciudad);
        int GetCantidad();
        List<Ciudad> GetCiudades();
        List<Ciudad> GetCiudadesPorPagina(int cantidad, int paginaActual);
    }
}
