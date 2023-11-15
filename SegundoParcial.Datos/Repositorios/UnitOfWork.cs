using SegundoParcial.Datos.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SegundoParcial.Datos.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly IDbConnection connection;
        private IDbTransaction transaction;
        public IRepositorioPuesto Puesto { get; }

        public IRepositorioSectores Sectores { get; }

        public IRepositorioPagos Pagos { get; }

        public IRepositorioHorario Horario { get; }

        public IRepositorioEmpleado Empleado { get; }

        public IRepositorioDetallePago DetallePago { get; }

        public IRepositorioCiudad Ciudad { get; }

        public IRepositorioAsistencia Asistencia { get; }
        public IRepositorioItemsSueldo ItemsSueldo { get; }


        public UnitOfWork(string CadenaDeConexion)
        {
            if (string.IsNullOrWhiteSpace(CadenaDeConexion))
            {
                throw new ArgumentException("la cadena de conexion no puede estar vacia.", nameof(CadenaDeConexion));
            }
            connection = new SqlConnection(CadenaDeConexion);
            connection.Open();
            transaction = connection.BeginTransaction();
            Puesto = new RepositorioPuestos(transaction);
            Sectores = new RepositorioSectores(transaction);
            Pagos = new RepositorioPagos(transaction);
            DetallePago = new RepositorioDetallePago(transaction);
            Horario = new RepositorioHorarios(transaction);
            Empleado = new RepositorioEmpleados(transaction);
            Ciudad = new RepositorioCiudades(transaction);
            Asistencia = new RepositorioAsistencias(transaction);
            ItemsSueldo = new RepositorioItemSueldo(transaction);


        }
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Dispose()
        {
            transaction?.Dispose();
            connection?.Dispose();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }
    }
}
