using System;
using System.Data;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IDbTransaction BeginTransaction();
        void Commit();
        void Rollback();
        IRepositorioPuesto Puesto { get; }
        IRepositorioSectores Sectores { get; }
        IRepositorioPagos Pagos { get; }
        IRepositorioHorario Horario { get; }
        IRepositorioEmpleado Empleado { get; }
        IRepositorioDetallePago DetallePago { get; }
        IRepositorioCiudad Ciudad { get; }
        IRepositorioAsistencia Asistencia { get; }
        IRepositorioItemsDetallePago ItemsDetallePago { get; }



    }
}
