using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.DetallePgo;
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

      
        public List<DetallePagoDto> GetDetallePago(int PagoId)
        {
            List<DetallePagoDto> lista = new List<DetallePagoDto>();
            string selectQuery = @"select DetallePagoId,PagoId,Importe from DetallePagos where PagoId=@PagoId";
            lista = transaction.Connection.Query<DetallePagoDto>(selectQuery,
                new { @PagoId }, transaction: transaction).ToList();

            return lista;
        }

       
    }
}
