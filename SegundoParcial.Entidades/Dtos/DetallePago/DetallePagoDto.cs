using SegundoParcial.Entidades.Entidades;
using System;

namespace SegundoParcial.Entidades.Dtos.DetallePgo
{
    public class DetallePagoDto
    {
        public int DetallePagoId { get; set; }

        public int EmpleadoId { get; set; }
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public double SueldoPorHora { get; set; }
        public double HorasExtras { get; set; }
        public double ObraSocial { get; set; }
        public double Descuentos { get; set; }
        public double importe => puesto.SueldoPorHora * asistencia.HorasTrabajadas;

        public Puesto puesto { get; set; } = new Puesto();
        public Asistencia asistencia { get; set; } = new Asistencia();





    }
}
