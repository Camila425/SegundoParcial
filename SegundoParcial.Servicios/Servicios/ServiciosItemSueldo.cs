using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosItemSueldo : IServiciosItemSueldo
    {
        public ServiciosItemSueldo()
        {
        }
        public List<ItemsSueldos> GetItemsSueldo()
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {

                try
                {
                    return unitOfWork.ItemsSueldo.GetItemsSueldo();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public ItemsSueldos GetItemSueldoPorId(int itemsueldoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.ItemsSueldo.GetItemsSueldoPorId(itemsueldoId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
