using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioAsistencias : IRepositorioAsistencia
    {
        private readonly IDbTransaction transaction;
        public RepositorioAsistencias(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }

        public void Agregar(Asistencia asistencia)
        {

            string insertQuery = @"INSERT INTO asistencias(empleadoId,Fecha,HoraEntrada,HoraSalida,HorasTrabajadas)
                                     VALUES(@empleadoId,@Fecha,@HoraEntrada,@HoraSalida,@HorasTrabajadas); SELECT SCOPE_IDENTITY()";
            int ID = transaction.Connection.QuerySingle<int>(insertQuery, asistencia, transaction: transaction);
            asistencia.AsistenciaId = ID;

        }

        public void Borrar(int asistenciaId)
        {

            string deleteQuery = "DELETE FROM Asistencias WHERE AsistenciaId=@AsistenciaId";
            transaction.Connection.Execute(deleteQuery, new { asistenciaId = asistenciaId }, transaction: transaction);

        }

        public void Editar(Asistencia asistencia)
        {

            string updateQuery = @"update Asistencias SET empleadoId=@empleadoId,Fecha=@Fecha,
                                   HoraEntrada=@HoraEntrada,HoraSalida=@HoraSalida,HorasTrabajadas=@HorasTrabajadas
                                  WHERE AsistenciaId=@AsistenciaId";
            transaction.Connection.Execute(updateQuery, asistencia, transaction: transaction);

        }

        public Asistencia GetAsistenciaPorId(int asistenciaId)
        {
            Asistencia asistencia = null;

            string selectQuery = @"SELECT e.empleadoId,a.AsistenciaId,e.Nombre,e.Dni,Fecha,HoraEntrada,
                                     HoraSalida,horastrabajadas=
                                     DATEDIFF(MINUTE, HoraEntrada, HoraSalida) / 60 
                                     FROM  Asistencias a inner join Empleados e on a.empleadoId=e.empleadoId
                                     WHERE AsistenciaId=@AsistenciaId";
            asistencia = transaction.Connection.QuerySingleOrDefault<Asistencia>(selectQuery,
                new { asistenciaId = asistenciaId }, transaction: transaction);

            return asistencia;
        }

        public List<AsistenciaDto> GetAsistenciaPorPagina(int cantidad, int pagina, int? EmpleadoId)
        {
            List<AsistenciaDto> listaAsistencia = new List<AsistenciaDto>();
            if (EmpleadoId == null)
            {
                string selectQuery = @"SELECT e.empleadoId,a.AsistenciaId,e.Nombre,e.Dni,Fecha,HoraEntrada,
                                     HoraSalida,horastrabajadas=
                                     DATEDIFF(MINUTE, HoraEntrada, HoraSalida) / 60 
                                     FROM  Asistencias a inner join Empleados e on a.empleadoId=e.empleadoId
	                                 ORDER BY e.Nombre,Fecha
                                     OFFSET @cantidadRegistros ROWS 
                                     FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var registroSeteados = cantidad * (pagina - 1);
                listaAsistencia = transaction.Connection.Query<AsistenciaDto>(selectQuery,
                new
                {
                    cantidadRegistros = registroSeteados,
                    cantidadPorPagina = cantidad,

                }, transaction: transaction).ToList();
            }
            else
            {


                string selectQuery = @"SELECT e.empleadoId,a.AsistenciaId,e.Nombre,e.Dni,Fecha,HoraEntrada,
                                     HoraSalida,horastrabajadas=
                                     DATEDIFF(MINUTE, HoraEntrada, HoraSalida) / 60 
                                     FROM  Asistencias a inner join Empleados e on a.empleadoId=e.empleadoId
                                     where e.empleadoId = @empleadoId
	                                 ORDER BY e.Nombre,Fecha
                                     OFFSET @cantidadRegistros ROWS 
                                     FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var registroSeteados = cantidad * (pagina - 1);

                listaAsistencia = transaction.Connection.Query<AsistenciaDto>(selectQuery,
                new
                {
                    EmpleadoId = EmpleadoId.Value,
                    cantidadRegistros = registroSeteados,
                    cantidadPorPagina = cantidad
                }, transaction: transaction).ToList();
            }
            return listaAsistencia;
        }

        public List<AsistenciaDto> GetAsistencias(int? EmpleadoId)
        {
            List<AsistenciaDto> lista = new List<AsistenciaDto>();
            string selectQuery;
            if (EmpleadoId == null)
            {
                selectQuery = @"SELECT e.Nombre,e.Dni,Fecha,HoraEntrada,HoraSalida,
                                     DATEDIFF(MINUTE, HoraEntrada, HoraSalida) / 60 AS HorasTrabajadas
                                     FROM  Asistencias a inner join Empleados e on a.empleadoId=e.empleadoId";
                lista = transaction.Connection.Query<AsistenciaDto>(selectQuery, transaction: transaction).ToList();
            }
            else
            {
                selectQuery = @"SELECT e.Nombre,e.Dni,Fecha,HoraEntrada,HoraSalida,
                                DATEDIFF(MINUTE, HoraEntrada, HoraSalida) / 60 AS HorasTrabajadas
                                FROM  Asistencias a inner join Empleados e on a.empleadoId=e.empleadoId  
                                where e.empleadoId=@empleadoId";
                lista = transaction.Connection.Query<AsistenciaDto>(selectQuery,
                    new { EmpleadoId = EmpleadoId }, transaction: transaction).ToList();
            }

            return lista;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            string selectQuery = "SELECT COUNT(*) FROM Asistencias";
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, transaction: transaction);

            return cantidad;
        }

        public int GetCantidad(int? empleadoId)
        {
            int cantidad = 0;
            string selectQuery;
            if (empleadoId == null)
            {
                selectQuery = "SELECT COUNT(*) FROM Asistencias ";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, transaction: transaction);
            }
            else
            {
                selectQuery = @"SELECT COUNT(*) FROM Asistencias WHERE empleadoId=@empleadoId";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery,
                    new { empleadoId = empleadoId }, transaction: transaction);
            }
            return cantidad;
        }
    }
}
