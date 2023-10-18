using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioSectores : IRepositorioSectores
    {
        private readonly string CadenaConexion;
        public RepositorioSectores()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Sector sector)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string insertQuery = "INSERT INTO Sectores(NombreSector) VALUES(@NombreSector); SELECT SCOPE_IDENTITY()";
                int ID = conn.QuerySingle<int>(insertQuery, sector);
                sector.SectorId = ID;
            }
        }

        public void Borrar(int sectorId)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string deleteQuery = "DELETE FROM Sectores WHERE SectorId=@SectorId";
                conn.Execute(deleteQuery,new { sectorId });
            }
        }

        public void Editar(Sector sector)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string updateQuery = "update Sectores SET NombreSector=@NombreSector WHERE SectorId=@SectorId";
                conn.Execute(updateQuery, sector);
            }
        }

        public bool EstaRelacionado(Sector sector)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Empleados WHERE SectorId=@SectorId";
                cantidad = conn.QuerySingle<int>(selectQuery, new { SectorId = sector.SectorId });
            }
            return cantidad > 0;
        }

        public bool Existe(Sector sector)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (sector.SectorId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Sectores WHERE NombreSector=@NombreSector";
                    cantidad = conn.ExecuteScalar<int>(selectQuery,sector);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Sectores WHERE NombreSector=@NombreSector AND SectorId!=@SectorId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, sector);
                }
            }
            return cantidad > 0;
        }

        public List<Sector> GetSectores()
        {
            List<Sector> lista = new List<Sector>();
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = "select SectorId,NombreSector from Sectores order by NombreSector";
                lista = conn.Query<Sector>(selectQuery).ToList();
            }
            return lista;
        }
    }
}
