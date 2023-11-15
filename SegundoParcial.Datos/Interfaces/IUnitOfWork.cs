using System;

namespace SegundoParcial.Datos.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        void BeginTransaction();
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
        IRepositorioItemsSueldo ItemsSueldo { get; }



    }
}
