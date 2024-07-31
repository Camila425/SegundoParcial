using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

            string insertQuery = @"INSERT INTO asistencias(empleadoId, Fecha, HoraEntrada, HoraSalida, HorasTrabajadas,HorasExtras)
                           VALUES (@empleadoId, @Fecha, @HoraEntrada, null, @HorasTrabajadas,@HorasExtras); 
                           SELECT SCOPE_IDENTITY()";
            int ID = transaction.Connection.QuerySingle<int>(insertQuery, asistencia, transaction: transaction);
            asistencia.AsistenciaId = ID;
            transaction.Commit();
        }

        public void Borrar(int asistenciaId)
        {
            string deleteQuery = "DELETE FROM Asistencias WHERE AsistenciaId=@AsistenciaId";
            transaction.Connection.Execute(deleteQuery, new { asistenciaId = asistenciaId }, transaction: transaction);

        }
        //edito la asistencia separo las horasnormales=5 a las horas extras 
        public void Editar(Asistencia asistencia)
        {
            using (var unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["MiConexion"].ToString()))
            {
                using (var transaction = unitOfWork.BeginTransaction())
                {
                    try
                    {
                        string updateQuery = @"UPDATE Asistencias SET HoraSalida = @HoraSalida, 
                                     HorasTrabajadas = DATEDIFF(HOUR, HoraEntrada, @HoraSalida),
                                     HorasExtras =  CASE 
                                     WHEN DATEDIFF(HOUR, HoraEntrada, @HoraSalida) > 5 
                                    THEN DATEDIFF(HOUR, HoraEntrada, @HoraSalida) - 5  
                                    ELSE 0  
                                    END 
                                   WHERE AsistenciaId = @AsistenciaId";

                        asistencia.HorasTrabajadas =0;
                        asistencia.HorasExtras = 0;
                        transaction.Connection.Execute(updateQuery, new
                        {
                            empleadoId = asistencia.empleadoId,
                            Fecha = asistencia.Fecha,
                            HoraEntrada = asistencia.HoraEntrada,
                            HoraSalida = asistencia.HoraSalida ?? (object)DBNull.Value,
                            AsistenciaId = asistencia.AsistenciaId
                        }, transaction: transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al editar la asistencia", ex);
                    }
                }
            }
        }

      

        public Asistencia GetAsistenciaPorId(int asistenciaId)
        {
            Asistencia asistencia = null;

            string selectQuery = @"SELECT e.empleadoId,a.AsistenciaId,e.Nombre,e.Dni,a.Fecha,HoraEntrada,p.ImporteTotal,
                                     HoraSalida,horastrabajadas=
                                     DATEDIFF(MINUTE, HoraEntrada, HoraSalida) / 60 ,HorasExtras
                                     FROM  Asistencias a inner join Empleados e on a.empleadoId=e.empleadoId
									 inner join Pagos p  on a.AsistenciaId=p.AsistenciaId
                                     WHERE a.AsistenciaId=@AsistenciaId";
            asistencia = transaction.Connection.QuerySingleOrDefault<Asistencia>(selectQuery,
                new { asistenciaId = asistenciaId }, transaction: transaction);
            return asistencia;
        }

        public List<AsistenciaDto> GetAsistenciaPorPagina(int cantidad, int pagina, int? EmpleadoId)
        {
            List<AsistenciaDto> listaAsistencia = new List<AsistenciaDto>();
            if (EmpleadoId == null)
            {
                string selectQuery = @"SELECT  e.empleadoId, a.AsistenciaId,e.Nombre,e.Dni,Fecha,HoraEntrada,HoraSalida, a.HorasTrabajadas,a.HorasExtras
                  FROM Asistencias a INNER JOIN   Empleados e ON a.empleadoId = e.empleadoId
                   ORDER BY  e.Nombre,Fecha
                    OFFSET  @cantidadRegistros ROWS 
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
                string selectQuery = @"SELECT  e.empleadoId, a.AsistenciaId,e.Nombre,e.Dni,Fecha,HoraEntrada,HoraSalida, a.HorasTrabajadas,a.HorasExtras
                                       FROM Asistencias a INNER JOIN   Empleados e ON a.empleadoId = e.empleadoId
                                       WHERE a.empleadoId = @empleadoId
                                       ORDER BY  e.Nombre,Fecha
                                       OFFSET  @cantidadRegistros ROWS 
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
                                     DATEDIFF(MINUTE, HoraEntrada, HoraSalida) / 60 AS HorasTrabajadas,HorasExtras
                                     FROM  Asistencias a inner join Empleados e on a.empleadoId=e.empleadoId";
                lista = transaction.Connection.Query<AsistenciaDto>(selectQuery, transaction: transaction).ToList();
            }
            else
            {
                selectQuery = @"SELECT e.Nombre,e.Dni,Fecha,HoraEntrada,HoraSalida,
                                DATEDIFF(MINUTE, HoraEntrada, HoraSalida) / 60 AS HorasTrabajadas,HorasExtras
                                FROM  Asistencias a inner join Empleados e on a.empleadoId=e.empleadoId  
                                where e.empleadoId=@empleadoId";
                lista = transaction.Connection.Query<AsistenciaDto>(selectQuery,
                    new { EmpleadoId = EmpleadoId }, transaction: transaction).ToList();
            }

            return lista;
        }
        //Cantidad Asistencias
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

      
        public bool Existe(Asistencia asistencia)
        {
            var cantidad = 0;
            string selectQuery;
            if (asistencia.AsistenciaId == 0)
            {
                selectQuery = "SELECT count(*) FROM Asistencias WHERE HoraSalida is null ";
            }
            else
            {
                selectQuery = "SELECT count(*) FROM Asistencias WHERE HoraSalida is null  AND AsistenciaId!=@AsistenciaId";
            }
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, asistencia, transaction: transaction);
            return cantidad > 0;
        }
    }
}
