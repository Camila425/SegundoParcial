using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }
        public int EstadoId { get; set; }
        public int HorarioId { get; set; }
        public int CiudadId { get; set; }
        public int PuestoId { get; set; }
        public int SectorId { get; set; }

    }
}
