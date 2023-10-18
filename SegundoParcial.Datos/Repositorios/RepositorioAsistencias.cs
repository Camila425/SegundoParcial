using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioAsistencias : IRepositorioAsistencia
    {
        private readonly string CadenaConexion;
        public RepositorioAsistencias()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Asistencia asistencia)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string insertQuery = @"INSERT INTO asistencias(empleadoId,Fecha,HoraEntrada,HoraSalida,Estado)
                                     VALUES(@empleadoId,@Fecha,@HoraEntrada,@HoraSalida,@Estado); SELECT SCOPE_IDENTITY()";
                int ID = conn.QuerySingle<int>(insertQuery,asistencia);
                asistencia.AsistenciaId = ID;
            }
        }

        public void Borrar(int asistenciaId)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string deleteQuery = "DELETE FROM Asistencias WHERE AsistenciaId=@AsistenciaId";
                conn.Execute(deleteQuery, new { asistenciaId = asistenciaId });
            }
        }

        public void Editar(Asistencia asistencia)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string updateQuery = @"update Asistencias SET empleadoId=@empleadoId,Fecha=@Fecha,
                                   HoraEntrada=@HoraEntrada,HoraSalida=@HoraSalida,Estado=@Estado
                                  WHERE AsistenciaId=@AsistenciaId";
                conn.Execute(updateQuery, asistencia);
            }
        }

        public Asistencia GetAsistenciaPorId(int asistenciaId)
        {
            Asistencia asistencia = null;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = @"SELECT AsistenciaId, empleadoId, Fecha,HoraEntrada,HoraSalida
                                       FROM Asistencias WHERE AsistenciaId=@AsistenciaId";
                asistencia = conn.QuerySingleOrDefault<Asistencia>(selectQuery, new { asistenciaId = asistenciaId });
            }
            return asistencia;
        }

        public List<AsistenciaDto> GetAsistenciaPorPagina(int cantidad, int pagina, int? EmpleadoId)
        {
            List<AsistenciaDto> listaAsistencia = new List<AsistenciaDto>();
            using (var conn = new SqlConnection(CadenaConexion))
            {

                if (EmpleadoId == null)
                {
                    string selectQuery = @"SELECT AsistenciaId,e.Nombre,e.Dni,Fecha,HoraEntrada,HoraSalida
                                       FROM Asistencias a 
                                      inner join Empleados e on a.empleadoId=e.empleadoId
                                       ORDER BY e.Nombre
                                      OFFSET @cantidadRegistros ROWS 
                                      FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var registroSeteados = cantidad * (pagina - 1);
                    listaAsistencia = conn.Query<AsistenciaDto>(selectQuery,
                    new
                    {
                        cantidadRegistros = registroSeteados,
                        cantidadPorPagina = cantidad,

                    }).ToList();
                }
                else
                {
                    string selectQuery = @"SELECT AsistenciaId,e.Nombre,e.Dni,Fecha,HoraEntrada,HoraSalida
                                       FROM Asistencias a 
                                      inner join Empleados e on a.empleadoId=e.empleadoId
									   where e.empleadoId=@empleadoId
                                       ORDER BY e.Nombre
                                      OFFSET @cantidadRegistros ROWS 
                                      FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var registroSeteados = cantidad * (pagina - 1);

                    listaAsistencia = conn.Query<AsistenciaDto>(selectQuery,
                    new
                    {
                        EmpleadoId = EmpleadoId.Value,
                        cantidadRegistros = registroSeteados,
                        cantidadPorPagina = cantidad
                    }).ToList();
                }
            }
            return listaAsistencia;
        }

        public List<AsistenciaDto> GetAsistencias(int? EmpleadoId)
        {
            List<AsistenciaDto> lista = new List<AsistenciaDto>();
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (EmpleadoId == null)
                {
                    selectQuery = @"SELECT a.AsistenciaId, e.Nombre,e.Dni,HoraEntrada,HoraSalida
                                    FROM Asistencias a inner JOIN Empleados e ON a.empleadoId=e.empleadoId    ";
                    lista = conn.Query<AsistenciaDto>(selectQuery).ToList();
                }
                else
                {
                    selectQuery = @"SELECT a.AsistenciaId, e.Nombre,e.Dni,HoraEntrada,HoraSalida
                                    FROM Asistencias a inner JOIN Empleados e ON a.empleadoId=e.empleadoId   
                                  where e.empleadoId=@empleadoId";
                    lista = conn.Query<AsistenciaDto>(selectQuery, new { EmpleadoId = EmpleadoId }).ToList();
                }
            }
            return lista;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Asistencias";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }
    }
}
