using Dapper;
using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace SegundoParcial.Datos.Repositorios
{
    public class RepositorioEmpleados : IRepositorioEmpleado
    {
        private readonly string CadenaConexion;
        public RepositorioEmpleados()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Empleado empleado)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
              string insertQuery = @"INSERT INTO Empleados(Nombre,Sexo,FechaNacimiento,Direccion,Telefono,Dni,
                                       HorarioId,CiudadId,PuestoId,SectorId)
                                      VALUES(@Nombre,@Sexo,@FechaNacimiento,@Direccion,@Telefono,@Dni,
                                      @HorarioId,@CiudadId,@PuestoId,@SectorId); SELECT SCOPE_IDENTITY()";
              int ID = conn.ExecuteScalar<int>(insertQuery,empleado);
              empleado.EmpleadoId = ID;
            }
        }

        public void Borrar(int empleadoId)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string deleteQuery = "DELETE FROM Empleados WHERE empleadoId=@empleadoId";
                conn.Execute(deleteQuery, new { empleadoId});
            }
        }

        public void Editar(Empleado empleado)
        {
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string updateQuery = @"update Empleados SET Nombre=@Nombre,Sexo=@Sexo,FechaNacimiento=@FechaNacimiento,
                                       Direccion=@Direccion,Telefono=@Telefono,Dni=@Dni,HorarioId=@HorarioId,
                                     CiudadId=@CiudadId,PuestoId=@PuestoId,SectorId=@SectorId 
                                     WHERE empleadoId=@empleadoId";
                conn.Execute(updateQuery, empleado);
            }
        }

        public bool EstaRelacionado(Empleado empleado)
        {
            int cantidadPagos=0;
            int cantidadAsistencias=0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = @"SELECT COUNT(*) FROM Pagos WHERE EmpleadoId=@EmpleadoId;
                                        SELECT COUNT(*) FROM Asistencias WHERE empleadoId=@empleadoId";
                using (var resultado = conn.QueryMultiple(selectQuery, new { EmpleadoId = empleado.EmpleadoId }))
                {
                    cantidadPagos = resultado.Read<int>().First();
                    cantidadAsistencias = resultado.Read<int>().First();
                }
            }
            return cantidadPagos + cantidadAsistencias > 0;
        }

        public bool Existe(Empleado empleado)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (empleado.EmpleadoId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM empleados WHERE dni=@dni";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, empleado);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM empleados WHERE dni=@dni AND empleadoId!=@empleadoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, empleado);
                }
            }
            return cantidad > 0;
        }

       

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Empleados";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }

        public int GetCantidad(int? PuestoId)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (PuestoId == null)
                {
                    selectQuery = "SELECT COUNT(*) FROM Empleados";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Empleados WHERE PuestoId=@PuestoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { PuestoId = PuestoId });
                }
            }
            return cantidad;
        }

        public List<EmpleadoDto> GetEmpleado(int? PuestoId, int? SectorId)
        {
            List<EmpleadoDto> lista = new List<EmpleadoDto>();
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery;
                if (PuestoId==null && SectorId==null)
                {
                    selectQuery = @"SELECT empleadoId,Nombre,Dni,p.NombrePuesto,s.NombreSector 
                                     FROM Empleados e inner JOIN  Puestos p on e.PuestoId=p.PuestoId
                                     inner join Sectores s on e.SectorId=s.SectorId
                                     order by Nombre  ";
                    lista = conn.Query<EmpleadoDto>(selectQuery).ToList();
                }
                else
                {
                    selectQuery = @"SELECT empleadoId,Nombre,Dni,p.NombrePuesto,s.NombreSector 
                                     FROM Empleados e inner JOIN  Puestos p on e.PuestoId=p.PuestoId
                                     inner join Sectores s on e.SectorId=s.SectorId
                          WHERE p.PuestoId=@PuestoId and s.NombreSector=@NombreSector order by Nombre";
                    lista = conn.Query<EmpleadoDto>(selectQuery, new {PuestoId=PuestoId,SectorId=SectorId }).ToList();
                }
            }
            return lista;
        }

        public Empleado GetEmpleadoPorId(int empleadoId)
        {
            Empleado empleado = null;
            using (var conn = new SqlConnection(CadenaConexion))
            {
                string selectQuery = @"SELECT empleadoId, Nombre, Sexo,FechaNacimiento,Direccion,Telefono,Dni,EstadoId,HorarioId,CiudadId,PuestoId,SectorId 
                                       FROM Empleados WHERE empleadoId=@empleadoId";
                empleado = conn.QuerySingleOrDefault<Empleado>(selectQuery,new { empleadoId = empleadoId });
            }
            return empleado;
        }

        public List<EmpleadoDto> GetEmpleadoPorPagina(int cantidad, int pagina,int? PuestoId)
        {
            List<EmpleadoDto> listaEmpleado = new List<EmpleadoDto>();
            using (var conn = new SqlConnection(CadenaConexion))
            {

                if (PuestoId==null)
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
                    listaEmpleado = conn.Query<EmpleadoDto>(selectQuery,
                    new
                    {
                        cantidadRegistros = registroSeteados,
                        cantidadPorPagina = cantidad,

                    }).ToList();
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

                    listaEmpleado = conn.Query<EmpleadoDto>(selectQuery,
                    new
                    {
                        PuestoId =PuestoId.Value,
                        cantidadRegistros = registroSeteados,
                        cantidadPorPagina = cantidad
                    }).ToList();
                }
            }
            return listaEmpleado;
        }
    }
}
