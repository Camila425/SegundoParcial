using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioEmpleados : IRepositorioEmpleado
    {
        private readonly IDbTransaction transaction;
        public RepositorioEmpleados(IDbTransaction Transaction)
        {
            transaction = Transaction;
        }

        public void Agregar(Empleado empleado)
        {

            string insertQuery = @"INSERT INTO Empleados(Nombre,Sexo,FechaNacimiento,Direccion,Telefono,Dni,
                                       HorarioId,CiudadId,PuestoId,SectorId)
                                      VALUES(@Nombre,@Sexo,@FechaNacimiento,@Direccion,@Telefono,@Dni,
                                      @HorarioId,@CiudadId,@PuestoId,@SectorId); SELECT SCOPE_IDENTITY()";
            int ID = transaction.Connection.ExecuteScalar<int>(insertQuery, empleado, transaction: transaction);
            empleado.EmpleadoId = ID;

        }

        public void Borrar(int empleadoId)
        {

            string deleteQuery = "DELETE FROM Empleados WHERE empleadoId=@empleadoId";
            transaction.Connection.Execute(deleteQuery, new { empleadoId }, transaction: transaction);

        }

        public void Editar(Empleado empleado)
        {

            string updateQuery = @"update Empleados SET Nombre=@Nombre,Sexo=@Sexo,FechaNacimiento=@FechaNacimiento,
                                       Direccion=@Direccion,Telefono=@Telefono,Dni=@Dni,HorarioId=@HorarioId,
                                     CiudadId=@CiudadId,PuestoId=@PuestoId,SectorId=@SectorId 
                                     WHERE empleadoId=@empleadoId";
            transaction.Connection.Execute(updateQuery, empleado, transaction: transaction);

        }

        public bool EstaRelacionado(Empleado empleado)
        {
            int cantidadPagos = 0;
            int cantidadAsistencias = 0;
            string selectQuery = @"SELECT COUNT(*) FROM Pagos WHERE EmpleadoId=@EmpleadoId;
                                        SELECT COUNT(*) FROM Asistencias WHERE empleadoId=@empleadoId";
            using (var resultado = transaction.Connection.QueryMultiple(selectQuery,
                new { EmpleadoId = empleado.EmpleadoId }, transaction: transaction))
            {
                cantidadPagos = resultado.Read<int>().First();
                cantidadAsistencias = resultado.Read<int>().First();
            }
            return cantidadPagos + cantidadAsistencias > 0;
        }

        public bool Existe(Empleado empleado)
        {
            var cantidad = 0;
            string selectQuery;
            if (empleado.EmpleadoId == 0)
            {
                selectQuery = "SELECT COUNT(*) FROM empleados WHERE dni=@dni";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, empleado, transaction: transaction);
            }
            else
            {
                selectQuery = "SELECT COUNT(*) FROM empleados WHERE dni=@dni AND empleadoId!=@empleadoId";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, empleado, transaction: transaction);
            }
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            string selectQuery = "SELECT COUNT(*) FROM Empleados";
            cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery, transaction: transaction);

            return cantidad;
        }

        public int GetCantidad(int? PuestoId)
        {
            int cantidad = 0;
            string selectQuery;
            if (PuestoId == null)
            {
                selectQuery = "SELECT COUNT(*) FROM Empleados";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery);
            }
            else
            {
                selectQuery = @"SELECT COUNT(*) FROM Empleados WHERE PuestoId=@PuestoId";
                cantidad = transaction.Connection.ExecuteScalar<int>(selectQuery,
                    new { PuestoId = PuestoId }, transaction: transaction);
            }

            return cantidad;
        }

        public List<EmpleadoDto> GetEmpleado(int? PuestoId, int? SectorId)
        {
            List<EmpleadoDto> lista = new List<EmpleadoDto>();
            string selectQuery;
            if (PuestoId == null && SectorId == null)
            {
                selectQuery = @"SELECT empleadoId,Nombre,Dni,p.NombrePuesto,s.NombreSector 
                                     FROM Empleados e inner JOIN  Puestos p on e.PuestoId=p.PuestoId
                                     inner join Sectores s on e.SectorId=s.SectorId
                                     order by Nombre  ";
                lista = transaction.Connection.Query<EmpleadoDto>(selectQuery, transaction: transaction).ToList();
            }
            else
            {
                selectQuery = @"SELECT empleadoId,Nombre,Dni,p.NombrePuesto,s.NombreSector 
                                     FROM Empleados e inner JOIN  Puestos p on e.PuestoId=p.PuestoId
                                     inner join Sectores s on e.SectorId=s.SectorId
                          WHERE p.PuestoId=@PuestoId and s.NombreSector=@NombreSector order by Nombre";
                lista = transaction.Connection.Query<EmpleadoDto>(selectQuery,
                    new { PuestoId = PuestoId, SectorId = SectorId }, transaction: transaction).ToList();
            }

            return lista;
        }

        public Empleado GetEmpleadoPorId(int empleadoId)
        {
            Empleado empleado = null;
            string selectQuery = @"SELECT empleadoId, Nombre, Sexo,FechaNacimiento,Direccion,Telefono,Dni,EstadoId,HorarioId,CiudadId,PuestoId,SectorId 
                                       FROM Empleados WHERE empleadoId=@empleadoId";
            empleado = transaction.Connection.QuerySingleOrDefault<Empleado>(selectQuery,
                new { empleadoId = empleadoId }, transaction: transaction);

            return empleado;
        }

        public List<EmpleadoDto> GetEmpleadoPorPagina(int cantidad, int pagina, int? PuestoId)
        {
            List<EmpleadoDto> listaEmpleado = new List<EmpleadoDto>();
            if (PuestoId == null)
            {
                string selectQuery = @"SELECT empleadoId, Nombre, Sexo,FechaNacimiento,Direccion,Telefono,Dni,h.HorarioId,c.NombreCiudad,p.NombrePuesto,s.NombreSector
                                       FROM Empleados e 
                                      inner join Horarios h on e.HorarioId=h.HorarioId
				                       inner join Ciudades c on e.CiudadId=c.CiudadId
				                       inner join Puestos p on e.PuestoId=p.PuestoId
				                       inner join Sectores s on e.SectorId=s.SectorId
                                       ORDER BY Nombre
                                      OFFSET @cantidadRegistros ROWS 
                                      FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var registroSeteados = cantidad * (pagina - 1);
                listaEmpleado = transaction.Connection.Query<EmpleadoDto>(selectQuery,
                new
                {
                    cantidadRegistros = registroSeteados,
                    cantidadPorPagina = cantidad,

                },transaction:transaction).ToList();
            }
            else
            {
                string selectQuery = @"SELECT empleadoId, Nombre, Sexo,FechaNacimiento,Direccion,Telefono,
                                           Dni,h.HorarioId,c.NombreCiudad,p.NombrePuesto,s.NombreSector
                                       FROM Empleados e 
                                      inner join Horarios h on e.HorarioId=h.HorarioId
				                       inner join Ciudades c on e.CiudadId=c.CiudadId
				                       inner join Puestos p on e.PuestoId=p.PuestoId
				                       inner join Sectores s on e.SectorId=s.SectorId
                                       where e.PuestoId=@PuestoId
                                       ORDER BY Nombre
                                      OFFSET @cantidadRegistros ROWS 
                                      FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var registroSeteados = cantidad * (pagina - 1);

                listaEmpleado = transaction.Connection.Query<EmpleadoDto>(selectQuery,
                new
                {
                    PuestoId = PuestoId.Value,
                    cantidadRegistros = registroSeteados,
                    cantidadPorPagina = cantidad
                },transaction:transaction).ToList();
            }
            return listaEmpleado;
        }
    }
}
