using SegundoParcial.Entidades.Enums;
using System;
using System.Collections.Generic;

namespace SegundoParcial.Entidades.Entidades
{
    public class Asistencia:ICloneable
    {
        public int AsistenciaId { get; set; }
        public int empleadoId { get; set; }

        public int PagoId { get; set; }


        public double HorasTrabajadas { get; set; }
        public int DetallePagoId { get; set; }
        public double SueldoPorHora { get; set; }
        public double HorasExtras { get; set; }
        public double Descuentos { get; set; }
        public double importe { get; set; }

        
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }

    
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
