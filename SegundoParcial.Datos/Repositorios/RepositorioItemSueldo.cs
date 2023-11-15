using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioItemSueldo : IRepositorioItemsSueldo
    {
        private readonly IDbTransaction transaction;
        public RepositorioItemSueldo(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }

        public List<ItemsSueldos> GetItemsSueldo()
        {

            List<ItemsSueldos> lista = new List<ItemsSueldos>();

            string selectQuery = "select ItemSueldoId,HorasExtras,Descuentos,SueldoPorHora,pagoId from ItemsSueldos";
            lista = transaction.Connection.Query<ItemsSueldos>(selectQuery, transaction: transaction).ToList();
            return lista;
        }

        public ItemsSueldos GetItemsSueldoPorId(int itemsueldoId)
        {
            string selectQuery = @"select ItemSueldoId,HorasExtras,Descuentos,SueldoPorHora,pagoId from ItemsSueldos
                                  where ItemSueldoId=@ItemSueldoId";
            var itemsueldo = transaction.Connection.QuerySingle<ItemsSueldos>(selectQuery,
          new { @ItemSueldoId = itemsueldoId }, transaction: transaction);
            return itemsueldo;
        }
    }
}
