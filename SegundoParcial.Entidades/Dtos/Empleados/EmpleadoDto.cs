﻿using SegundoParcial.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades.Dtos.Empleados
{
    public class EmpleadoDto:ICloneable
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string NombrePuesto { get; set; }
        public string NombreSector { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
