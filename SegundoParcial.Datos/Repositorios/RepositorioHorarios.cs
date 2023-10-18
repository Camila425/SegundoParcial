using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Horarios;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioHorarios:IRepositorioHorario
    {
        private readonly string CadenaConexion;
        public RepositorioHorarios()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Horario horario)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string insertQuery = @"INSERT INTO Horarios (HoraInicio,HoraFin,DiasLaborales,TipoDeHorarioId)
                                    VALUES (@HoraInicio,@HoraFin,@DiasLaborales,@TipoDeHorarioId); SELECT SCOPE_IDENTITY()";
                int ID = conn.QuerySingle<int>(insertQuery,horario);
                horario.HorarioId = ID;
            }
        }

        public void Borrar(int horarioId)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string deleteQuery = "DELETE FROM Horarios WHERE HorarioId=@HorarioId";
                conn.Execute(deleteQuery, new { horarioId = horarioId });
            }
        }

        public void Editar(Horario horario)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string updateQuery = "update Horarios SET HoraInicio=@HoraInicio,HoraFin=@HoraFin,TipoDeHorarioId=@TipoDeHorarioId WHERE HorarioId=@HorarioId";
                conn.Execute(updateQuery,horario);
            }
        }

        public bool Existe(Horario horario)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (horario.HorarioId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Horarios WHERE DiasLaborales=@DiasLaborales";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, horario);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Horarios WHERE DiasLaborales=@DiasLaborales AND HorarioId!=@HorarioId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, horario);
                }
            }
            return cantidad > 0;
        }

        public Horario GetHorarioPorId(int horarioId)
        {
            Horario horario = null;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = @"SELECT HorarioId, HoraInicio, HoraFin,DiasLaborales,TipoDeHorarioId
                                       FROM Horarios WHERE HorarioId=@HorarioId";
                horario = conn.QuerySingleOrDefault<Horario>(selectQuery,new { horarioId = horarioId });
            }
            return horario;
        }

        public List<HorarioDto> GetHorarios(int? TipoDeHorarioId)
        {
            List<HorarioDto> lista = new List<HorarioDto>();
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (TipoDeHorarioId == null)
                {
                    selectQuery = @"SELECT HorarioId, t.TipoDeHorarioId,t.TipoHorario ,HoraInicio,HoraFin
                        FROM Horarios h inner JOIN TiposDeHorarios t ON t.TipoDeHorarioId=h.TipoDeHorarioId";
                    lista = conn.Query<HorarioDto>(selectQuery).ToList();
                }
                else
                {
                    selectQuery = "SELECT HorarioId, t.TipoHorario, HoraInicio,HoraFin FROM Horarios h " +
                        "INNER JOIN TiposDeHorarios t ON t.TipoDeHorarioId=h.TipoDeHorarioId " +
                        "WHERE h.TipoDeHorarioId=@TipoDeHorarioId";
                    lista = conn.Query<HorarioDto>(selectQuery, new { TipoDeHorarioId = TipoDeHorarioId }).ToList();
                }
            }
            return lista;
        }

        public List<TipoDeHorario> GetTipoHorarios()
        {
            List<TipoDeHorario> lista = new List<TipoDeHorario>();
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = "select TipoDeHorarioId,TipoHorario from TiposDeHorarios order by TipoHorario";
                lista = conn.Query<TipoDeHorario>(selectQuery).ToList();
            }
            return lista;
        }
    }
}
