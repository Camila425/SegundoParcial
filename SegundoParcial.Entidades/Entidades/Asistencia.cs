using SegundoParcial.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades.Entidades
{
    public class Asistencia
    {
        public int AsistenciaId { get; set; }
        public int empleadoId { get; set; }
        public string Dni { get; set; }
        public Estados Estado { get; set; }
        public Empleado empleado = new Empleado();

        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
    }
}
