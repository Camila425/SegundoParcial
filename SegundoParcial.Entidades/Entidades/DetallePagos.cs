namespace SegundoParcial.Entidades.Entidades
{
    public class DetallePagos
    {
        public int DetallePagoId { get; set; }
        public int ItemDetallePagoId { get; set; }
        public int PagoId { get; set; }
        public int empleadoId { get; set; }
        public double ImporteTotal { get; set; }
        public Puesto puesto { get; set; } = new Puesto();
        public Asistencia asistencia { get; set; } = new Asistencia();

        public double CalcularImporte()
        {
            return ImporteTotal = puesto.SueldoPorHora * asistencia.HorasTrabajadas;
        }
    }
}
