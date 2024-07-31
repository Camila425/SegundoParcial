using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.ItemsDetallePago;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosItemsDetallePago : IServiciosItemsDetallePago
    {
        public ServiciosItemsDetallePago()
        {
        }
        public List<ItemsDetallePagoDto> GetItemsSueldo(int pagoid)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {

                try
                {
                    return unitOfWork.ItemsDetallePago.GetItemsDetallePago(pagoid);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public ItemsDetallePagoDto GetItemSueldoPorId(int itemsueldoId)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                try
                {
                    return unitOfWork.ItemsDetallePago.GetItemsDetallePagoId(itemsueldoId);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        
    }
}
