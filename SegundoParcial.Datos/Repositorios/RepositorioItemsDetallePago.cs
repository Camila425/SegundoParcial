using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.ItemsDetallePago;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioItemsDetallePago : IRepositorioItemsDetallePago
    {
        private readonly IDbTransaction transaction;
        public RepositorioItemsDetallePago(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }
        public List<ItemsDetallePagoDto> GetItemsDetallePago(int PagoId)
        {

            List<ItemsDetallePagoDto> lista = new List<ItemsDetallePagoDto>();

            string selectQuery = @"SELECT it.ItemDetallePagoId,p.PagoId,it.Fecha,a.HorasTrabajadas,a.HorasExtras,pt.SueldoPorHora,p.ImporteTotal,it.Sueldo
                                   FROM pagos p INNER JOIN Asistencias a ON p.AsistenciaId = a.AsistenciaId
                                   INNER JOIN Empleados e ON e.empleadoId = a.empleadoId
                                    INNER JOIN Puestos pt ON e.PuestoId = pt.PuestoId
                                    INNER JOIN ItemsDetallePago it ON p.PagoId = it.PagoId
                                     WHERE p.PagoId = @PagoId";
            lista = transaction.Connection.Query<ItemsDetallePagoDto>(selectQuery, new { @PagoId }, transaction: transaction).ToList();
            transaction.Commit();
            return lista;
        }


        public ItemsDetallePagoDto GetItemsDetallePagoId(int itemsueldoId)
        {
            string selectQuery = @"select ItemDetallePagoId,Descripcion,Tipo,p.ImporteTotal
                                  from ItemsDetallePago it inner join Pagos p on p.PagoId=it.PagoId
								  where it.ItemDetallePagoId=@ItemDetallePagoId";
            var itemsueldo = transaction.Connection.QuerySingle<ItemsDetallePagoDto>(selectQuery,
          new { ItemSueldoId = itemsueldoId }, transaction: transaction);
            return itemsueldo;
        }

    }
}
