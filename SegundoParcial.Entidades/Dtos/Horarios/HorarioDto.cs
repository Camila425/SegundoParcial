﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades.Dtos.Horarios
{
    public class HorarioDto:ICloneable
    {
        public int HorarioId { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string TipoHorario { get; set; }
        public string DiasLaborales { get; set; }
        public int TipoDeHorarioId { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
