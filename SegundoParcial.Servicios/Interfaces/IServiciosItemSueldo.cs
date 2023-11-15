using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Interfaces
{
    public interface IServiciosItemSueldo
    {
        List<ItemsSueldos> GetItemsSueldo();
        ItemsSueldos GetItemSueldoPorId(int ItemsSueldoid);


    }
}
