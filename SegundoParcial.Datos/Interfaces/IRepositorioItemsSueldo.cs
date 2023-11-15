using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IRepositorioItemsSueldo
    {
        List<ItemsSueldos> GetItemsSueldo();
        ItemsSueldos GetItemsSueldoPorId(int itemsueldoId);
    }
}
