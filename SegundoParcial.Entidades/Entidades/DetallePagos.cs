namespace SegundoParcial.Entidades.Entidades
{
    public class DetallePagos
    {
        public int DetallePagoId { get; set; }
        public int ItemSueldoId { get; set; }
        public int PagoId { get; set; }
        public int empleadoId { get; set; }
        public double Importe { get; set; }
        public Puesto puesto { get; set; } = new Puesto();
        public Asistencia asistencia { get; set; } = new Asistencia();

        public Empleado empleado { get; set; }
        public double CalcularImporte()
        {
            return Importe = puesto.SueldoPorHora * asistencia.HorasTrabajadas;
        }
    }
}
