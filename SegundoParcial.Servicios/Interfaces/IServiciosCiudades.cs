using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosCiudades
    {
        void Borrar(int ciudadId);
        bool EstaRelacionada(Ciudad ciudad);
        bool Existe(Ciudad ciudad);
        int GetCantidad();
        List<Ciudad> GetCiudades();
        List<Ciudad> GetCiudadesPorPagina(int registrosPorPagina, int paginaActual);
        void Guardar(Ciudad ciudad);
    }
}
