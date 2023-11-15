using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioPuestos : IRepositorioPuesto
    {
        private readonly IDbTransaction transaction;
        public RepositorioPuestos(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }

        public void Agregar(Puesto puesto)
        {

            string insertQuery = "INSERT INTO Puestos(NombrePuesto,SueldoPorHora) VALUES(@NombrePuesto,@SueldoPorHora); SELECT SCOPE_IDENTITY()";
            int ID = transaction.Connection.QuerySingle<int>(insertQuery, puesto, transaction: transaction);
            puesto.PuestoId = ID;

        }

        public void Borrar(int puestoId)
        {

            string deleteQuery = "DELETE FROM Puestos WHERE PuestoId=@PuestoId";
            transaction.Connection.Execute(deleteQuery, new { puestoId = puestoId }, transaction: transaction);

        }

        public void Editar(Puesto puesto)
        {

            string updateQuery = "update Puestos SET NombrePuesto=@NombrePuesto,SueldoPorHora=@SueldoPorHora WHERE PuestoId=@PuestoId";
            transaction.Connection.Execute(updateQuery, puesto, transaction: transaction);

        }

        public bool Existe(Puesto puesto)
        {
            var cantidad = 0;
            string selectQuery;
            if (puesto.PuestoId == 0)
            {
                selectQuery = "SELECT COUNT(*) FROM Puestos WHERE NombrePuesto=@NombrePuesto";
            }
            else
            {
                selectQuery = "SELECT COUNT(*) FROM Puestos WHERE NombrePuesto=@NombrePuesto AND PuestoId!=@PuestoId";
            }
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, puesto, transaction: transaction);

            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            string selectQuery = "SELECT COUNT(*) FROM Puestos";
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, transaction: transaction);
            return cantidad;
        }

        public List<Puesto> GetPuestoPorPagina(int cantidad, int pagina)
        {
            List<Puesto> listapuesto = new List<Puesto>();
            string selectQuery = @"SELECT PuestoId, NombrePuesto, SueldoPorHora FROM Puestos
                    ORDER BY NombrePuesto
                    OFFSET @cantidadRegistros ROWS 
                    FETCH NEXT @cantidadPorPagina ROWS ONLY";

            listapuesto = transaction.Connection.Query<Puesto>(selectQuery,
            new
            {
                cantidadRegistros = (pagina - 1) * cantidad,
                cantidadPorPagina = cantidad
            }, transaction: transaction).ToList();
            return listapuesto;
        }

        public Puesto GetPuestoPorId(int puestoId)
        {
            Puesto puesto = null;
            string selectQuery = @"SELECT PuestoId,NombrePuesto,SueldoPorHora FROM Puestos WHERE PuestoId=@PuestoId";
            puesto = transaction.Connection.QuerySingleOrDefault<Puesto>(selectQuery, new { puestoId = puestoId }, transaction: transaction);
            return puesto;
        }

        public List<Puesto> GetPuestos()
        {
            List<Puesto> lista = new List<Puesto>();

            string selectQuery = "select PuestoId,NombrePuesto,SueldoPorHora from Puestos order by NombrePuesto";
            lista = transaction.Connection.Query<Puesto>(selectQuery,transaction:transaction).ToList();
            return lista;
        }

        public bool EstaRelacionado(Puesto puesto)
        {
            int cantidad = 0;
                string selectQuery = "SELECT COUNT(*) FROM Empleados WHERE PuestoId=@PuestoId";
                cantidad = transaction.Connection.QuerySingle<int>(selectQuery, new { PuestoId = puesto.PuestoId },transaction:transaction);
            return cantidad > 0;
        }
    }
}
