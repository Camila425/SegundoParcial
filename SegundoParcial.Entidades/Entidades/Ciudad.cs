using System;

namespace SegundoParcial.Entidades.Entidades
{
    public class Ciudad : ICloneable
    {
        //ciudades
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
