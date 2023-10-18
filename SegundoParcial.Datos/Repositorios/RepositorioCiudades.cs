using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioCiudades : IRepositorioCiudad
    {
        private readonly string CadenaConexion;
        public RepositorioCiudades()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Ciudad ciudad)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string insertQuery = "INSERT INTO Ciudades(NombreCiudad) VALUES(@NombreCiudad); SELECT SCOPE_IDENTITY()";
                int ID = conn.QuerySingle<int>(insertQuery, ciudad);
                ciudad.CiudadId = ID;
            }
        }

        public void Borrar(int ciudadId)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string deleteQuery = "DELETE FROM Ciudades WHERE CiudadId=@CiudadId";
                conn.Execute(deleteQuery, new { ciudadId = ciudadId });
            }
        }

        public void Editar(Ciudad ciudad)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string updateQuery = "update Ciudades SET NombreCiudad=@NombreCiudad WHERE CiudadId=@CiudadId";
                conn.Execute(updateQuery,ciudad);
            }
        }

        public bool EstaRelacionada(Ciudad ciudad)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Empleados WHERE CiudadId=@CiudadId";
                cantidad = conn.QuerySingle<int>(selectQuery, new { CiudadId = ciudad.CiudadId });
            }
            return cantidad > 0;
        }

        public bool Existe(Ciudad ciudad)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (ciudad.CiudadId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Ciudades WHERE NombreCiudad=@NombreCiudad";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, ciudad);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Ciudades WHERE NombreCiudad=@NombreCiudad AND CiudadId!=@CiudadId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, ciudad);
                }
            }
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = "select count(*) from Ciudades";
                cantidad = conn.ExecuteScalar<int>(selectQuery);

            }
            return cantidad;
        }

        public List<Ciudad> GetCiudades()
        {
            List<Ciudad> lista = new List<Ciudad>();
            using (var conn = new SqlConnection(CadenaConexion))
            {
               string selectQuery = "select CiudadId,NombreCiudad from Ciudades order by NombreCiudad";
               lista = conn.Query<Ciudad>(selectQuery).ToList();
            }
            return lista;
        }

        public List<Ciudad> GetCiudadesPorPagina(int cantidad, int paginaActual)
        {
            List<Ciudad> lista = new List<Ciudad>();
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = @"SELECT CiudadId, NombreCiudad FROM Ciudades 
                 ORDER BY NombreCiudad OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidad ROWS ONLY";
                var cantidadRegistros = cantidad * (paginaActual - 1);
                lista = conn.Query<Ciudad>(selectQuery, new { cantidadRegistros, cantidad }).ToList();
            }
            return lista;
        }
    }
}
