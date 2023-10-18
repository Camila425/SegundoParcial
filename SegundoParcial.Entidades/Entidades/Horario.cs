using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades.Entidades
{
    public class Horario:ICloneable
    {
        public int HorarioId { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string DiasLaborales { get; set; }
        public int TipoDeHorarioId { get; set; }
        public TipoDeHorario tipoHorario { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
