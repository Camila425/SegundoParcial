using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioCiudades : IRepositorioCiudad
    {
        private readonly IDbTransaction transaction;
        public RepositorioCiudades(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }
        public void Agregar(Ciudad ciudad)
        {

            string insertQuery = "INSERT INTO Ciudades(NombreCiudad) VALUES(@NombreCiudad); SELECT SCOPE_IDENTITY()";
            int ID = transaction.Connection.QuerySingle<int>(insertQuery, ciudad, transaction: transaction);
            ciudad.CiudadId = ID;

        }

        public void Borrar(int ciudadId)
        {
            string deleteQuery = "DELETE FROM Ciudades WHERE CiudadId=@CiudadId";
            transaction.Connection.Execute(deleteQuery, new { ciudadId = ciudadId }, transaction: transaction);
        }

        public void Editar(Ciudad ciudad)
        {
            string updateQuery = "update Ciudades SET NombreCiudad=@NombreCiudad WHERE CiudadId=@CiudadId";
            transaction.Connection.Execute(updateQuery, ciudad, transaction: transaction);
        }

        public bool EstaRelacionada(Ciudad ciudad)
        {
            int cantidad = 0;
            string selectQuery = "SELECT COUNT(*) FROM Empleados WHERE CiudadId=@CiudadId";
            cantidad = transaction.Connection.QuerySingle<int>(selectQuery,
                new { CiudadId = ciudad.CiudadId }, transaction: transaction);

            return cantidad > 0;
        }

        public bool Existe(Ciudad ciudad)
        {
            var cantidad = 0;
            string selectQuery;
            if (ciudad.CiudadId == 0)
            {
                selectQuery = "SELECT COUNT(*) FROM Ciudades WHERE NombreCiudad=@NombreCiudad";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, ciudad, transaction: transaction);
            }
            else
            {
                selectQuery = "SELECT COUNT(*) FROM Ciudades WHERE NombreCiudad=@NombreCiudad AND CiudadId!=@CiudadId";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, ciudad, transaction: transaction);
            }
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
                string selectQuery = "select count(*) from Ciudades";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery,transaction:transaction);
            return cantidad;
        }

        public List<Ciudad> GetCiudades()
        {
            List<Ciudad> lista = new List<Ciudad>();
                string selectQuery = "select CiudadId,NombreCiudad from Ciudades order by NombreCiudad";
                lista = transaction.Connection.Query<Ciudad>(selectQuery,transaction:transaction).ToList();
            return lista;
        }

        public List<Ciudad> GetCiudadesPorPagina(int cantidad, int paginaActual)
        {
            List<Ciudad> lista = new List<Ciudad>();
                string selectQuery = @"SELECT CiudadId, NombreCiudad FROM Ciudades 
                 ORDER BY NombreCiudad OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidad ROWS ONLY";
                var cantidadRegistros = cantidad * (paginaActual - 1);
                lista = transaction.Connection.Query<Ciudad>(selectQuery,
                    new { cantidadRegistros, cantidad },transaction:transaction).ToList();
            return lista;
        }
    }
}
