using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades.Entidades
{
    public class Puesto:ICloneable
    {
        public int PuestoId { get; set; }
        public string NombrePuesto { get; set; }
        public double Sueldo { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
