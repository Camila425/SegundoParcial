﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades.Entidades
{
    public class Sector:ICloneable
    {
        public int SectorId { get; set; }
        public string NombreSector { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();    
        }
    }
}
