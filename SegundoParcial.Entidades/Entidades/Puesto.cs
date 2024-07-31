using System;

namespace SegundoParcial.Entidades.Entidades
{
    public class Puesto:ICloneable
    {
        public int PuestoId { get; set; }
        public string NombrePuesto { get; set; }
        public double SueldoPorHora { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
