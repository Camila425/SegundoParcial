using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Horarios;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioHorarios : IRepositorioHorario
    {
        private readonly IDbTransaction transaction;
        public RepositorioHorarios(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }

        public void Agregar(Horario horario)
        {
            string insertQuery = @"INSERT INTO Horarios (HoraInicio,HoraFin,TipoDeHorarioId)
                                    VALUES (@HoraInicio,@HoraFin,@TipoDeHorarioId); SELECT SCOPE_IDENTITY()";
            int ID = transaction.Connection.QuerySingle<int>(insertQuery,horario , transaction: transaction);
            horario.HorarioId = ID;
        }

        public void Borrar(int horarioId)
        {
            string deleteQuery = "DELETE FROM Horarios WHERE HorarioId=@HorarioId";
            transaction.Connection.Execute(deleteQuery, new { horarioId = horarioId }, transaction: transaction);
        }

        public void Editar(Horario horario)
        {
            string updateQuery = "update Horarios SET HoraInicio=@HoraInicio,HoraFin=@HoraFin,TipoDeHorarioId=@TipoDeHorarioId WHERE HorarioId=@HorarioId";
            transaction.Connection.Execute(updateQuery, horario, transaction: transaction);
        }

        public bool Existe(Horario horario)
        {
            var cantidad = 0;
            string selectQuery;
            if (horario.HorarioId == 0)
            {
                selectQuery = "SELECT COUNT(*) FROM Horarios  WHERE HoraInicio=@HoraInicio";
            }
            else
            {
                selectQuery = "SELECT COUNT(*) FROM Horarios  WHERE HoraInicio=@HoraInicio AND HorarioId!=@HorarioId";
            }
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, horario, transaction: transaction);
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            string selectQuery = "SELECT COUNT(*) FROM Horarios";
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, transaction: transaction);
            return cantidad;
        }

        public Horario GetHorarioPorId(int horarioId)
        {
            Horario horario = null;
            string selectQuery = @"SELECT HorarioId, HoraInicio, HoraFin,TipoDeHorarioId
                                       FROM Horarios WHERE HorarioId=@HorarioId";
            horario = transaction.Connection.QuerySingleOrDefault<Horario>(selectQuery,
                new { horarioId = horarioId }, transaction: transaction);
            return horario;
        }

        public List<HorarioDto> GetHorarioPorPagina(int cantidad, int pagina, int? TipoHorario)
        {
            List<HorarioDto> listaHorario = new List<HorarioDto>();
            if (TipoHorario == null)
            {
                string selectQuery = @"SELECT HorarioId, t.TipoDeHorarioId,t.TipoHorario ,HoraInicio,HoraFin
                                       FROM Horarios h inner JOIN TiposDeHorarios t ON t.TipoDeHorarioId=h.TipoDeHorarioId
									   order by h.HorarioId
                                      offset @cantidadRegistros ROWS 
                                      FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var registroSeteados = cantidad * (pagina - 1);
                listaHorario = transaction.Connection.Query<HorarioDto>(selectQuery,
                new
                {
                    cantidadRegistros = registroSeteados,
                    cantidadPorPagina = cantidad,

                },transaction:transaction).ToList();
            }
            else
            {
                string selectQuery = @"SELECT HorarioId, t.TipoDeHorarioId,t.TipoHorario ,HoraInicio,HoraFin
                                       FROM Horarios h inner JOIN TiposDeHorarios t ON t.TipoDeHorarioId=h.TipoDeHorarioId
                                       where t.TipoDeHorarioId=@TipoDeHorarioId
									   order by h.HorarioId
                                      OFFSET @cantidadRegistros ROWS 
                                      FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var registroSeteados = cantidad * (pagina - 1);

                listaHorario = transaction.Connection.Query<HorarioDto>(selectQuery,
                new
                {
                    TipoHorario = TipoHorario.Value,
                    cantidadRegistros = registroSeteados,
                    cantidadPorPagina = cantidad
                },transaction:transaction).ToList();
            }
            return listaHorario;
        }

        public List<HorarioDto> GetHorarios(int? TipoDeHorarioId)
        {
            List<HorarioDto> lista = new List<HorarioDto>();

                string selectQuery;
                if (TipoDeHorarioId == null)
                {
                    selectQuery = @"SELECT HorarioId, t.TipoDeHorarioId,t.TipoHorario ,HoraInicio,HoraFin
                        FROM Horarios h inner JOIN TiposDeHorarios t ON t.TipoDeHorarioId=h.TipoDeHorarioId";
                    lista = transaction.Connection.Query<HorarioDto>(selectQuery,transaction:transaction).ToList();
                }
                else
                {
                    selectQuery = "SELECT HorarioId, t.TipoHorario, HoraInicio,HoraFin FROM Horarios h " +
                        "INNER JOIN TiposDeHorarios t ON t.TipoDeHorarioId=h.TipoDeHorarioId " +
                        "WHERE h.TipoDeHorarioId=@TipoDeHorarioId";
                    lista = transaction.Connection.Query<HorarioDto>(selectQuery, 
                        new { TipoDeHorarioId = TipoDeHorarioId },transaction:transaction).ToList();
                }
            return lista;
        }

        public List<TipoDeHorario> GetTipoHorarios()
        {
            List<TipoDeHorario> lista = new List<TipoDeHorario>();
                string selectQuery = "select TipoDeHorarioId,TipoHorario from TiposDeHorarios order by TipoHorario";
                lista = transaction.Connection.Query<TipoDeHorario>(selectQuery,transaction:transaction).ToList();
            return lista;
        }
    }
}
