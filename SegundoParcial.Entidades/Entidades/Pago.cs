using SegundoParcial.Entidades.Dtos.DetallePgo;
using SegundoParcial.Entidades.Enums;
using System;
using System.Collections.Generic;

namespace SegundoParcial.Entidades.Entidades
{
    public class Pago
    {
        public int PagoId { get; set; }
        public int DetallePagoId { get; set; }

        public int EmpleadoId { get; set; }
        public double SueldoPorHora { get; set; }
        public double HorasExtras { get; set; }
        public double Descuentos { get; set; }
        public Puesto puesto { get; set; } = new Puesto();
        public Asistencia asistencia { get; set; } = new Asistencia();


        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public EstadoPago EstadoPago { get; set; }
        public List<DetallePagos> Detalles { get; set; } = new List<DetallePagos>();
        public Pago()
        {
            Detalles = new List<DetallePagos>();
        }
        public double CalcularImporte()
        {
          return  Importe = puesto.SueldoPorHora * asistencia.HorasTrabajadas;
        }

    }
}
