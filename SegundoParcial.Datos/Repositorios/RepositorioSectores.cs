using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioSectores : IRepositorioSectores
    {
        private readonly IDbTransaction transaction;
        public RepositorioSectores(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }

        public void Agregar(Sector sector)
        {

            string insertQuery = "INSERT INTO Sectores(NombreSector) VALUES(@NombreSector); SELECT SCOPE_IDENTITY()";
            int ID = transaction.Connection.QuerySingle<int>(insertQuery, sector, transaction: transaction);
            sector.SectorId = ID;
        }

        public void Borrar(int sectorId)
        {
            string deleteQuery = "DELETE FROM Sectores WHERE SectorId=@SectorId";
            transaction.Connection.Execute(deleteQuery, new { sectorId }, transaction: transaction);

        }

        public void Editar(Sector sector)
        {

            string updateQuery = "update Sectores SET NombreSector=@NombreSector WHERE SectorId=@SectorId";
            transaction.Connection.Execute(updateQuery, sector, transaction: transaction);

        }

        public bool EstaRelacionado(Sector sector)
        {
            int cantidad = 0;
            string selectQuery = "SELECT COUNT(*) FROM Empleados WHERE SectorId=@SectorId";
            cantidad = transaction.Connection.QuerySingle<int>(selectQuery, new { SectorId = sector.SectorId }, transaction: transaction);

            return cantidad > 0;
        }

        public bool Existe(Sector sector)
        {
            var cantidad = 0;

            string selectQuery;
            if (sector.SectorId == 0)
            {
                selectQuery = "SELECT COUNT(*) FROM Sectores WHERE NombreSector=@NombreSector";
            }
            else
            {
                selectQuery = "SELECT COUNT(*) FROM Sectores WHERE NombreSector=@NombreSector AND SectorId!=@SectorId";
            }
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, sector, transaction: transaction);
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            string selectQuery = "SELECT COUNT(*) FROM Sectores";
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, transaction: transaction);

            return cantidad;
        }

        public List<Sector> GetSectores()
        {
            List<Sector> lista = new List<Sector>();
            string selectQuery = "select SectorId,NombreSector from Sectores order by NombreSector";
            lista = transaction.Connection.Query<Sector>(selectQuery, transaction: transaction).ToList();

            return lista;
        }

        public List<Sector> GetSectorPorPagina(int cantidad, int paginaActual)
        {
            List<Sector> lista = new List<Sector>();

            string selectQuery = @"SELECT SectorId, NombreSector FROM Sectores 
                 ORDER BY NombreSector OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidad ROWS ONLY";
            var cantidadRegistros = cantidad * (paginaActual - 1);
            lista = transaction.Connection.Query<Sector>(selectQuery, new { cantidadRegistros, cantidad },transaction:transaction).ToList();

            return lista;
        }
    }
}
