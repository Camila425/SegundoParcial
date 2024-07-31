using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.ItemsDetallePago;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioDetallePago : IRepositorioDetallePago
    {
        private readonly IDbTransaction transaction;
        public RepositorioDetallePago(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }

        public List<ItemsDetallePagoDto> GetDetallePago(int PagoId)
        {
            List<ItemsDetallePagoDto> lista = new List<ItemsDetallePagoDto>();

            string selectQuery = @"select pagoid,SueldoPorHora,HorasExtras,Descuentos from ItemsSueldos where PagoId=@PagoId";
            lista = transaction.Connection.Query<ItemsDetallePagoDto>(selectQuery,
                new { @PagoId }, transaction: transaction).ToList();

            return lista;
        }

        public List<ItemsDetallePago> GetItemsDetallePago(int pagoId)
        {
            List<ItemsDetallePago> lista = new List<ItemsDetallePago>();

            string selectQuery = @"select pagoid,SueldoPorHora,HorasExtras,Descuentos from ItemsSueldos where PagoId=@PagoId";
            lista = transaction.Connection.Query<ItemsDetallePago>(selectQuery,
                new { @pagoId }, transaction: transaction).ToList();
            return lista;
        }
    }
}
