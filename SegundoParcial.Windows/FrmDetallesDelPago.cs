using SegundoParcial.Entidades.Dtos.ItemsDetallePago;
using SegundoParcial.Entidades.Dtos.PagoDetalleDto;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Windows.Helpers;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmDetallesDelPago : Form
    {
        private PagoDetalleDto pagoDetalleDto=new PagoDetalleDto();

        private ItemsDetallePagoDto itemsDetallePagoDto = new ItemsDetallePagoDto();
        

        public FrmDetallesDelPago()
        {
            InitializeComponent();
        }

        public void SetPagoDetalle(PagoDetalleDto itemDetalleDto)
        {
            this.pagoDetalleDto = itemDetalleDto;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarDatosEmpleado(pagoDetalleDto.pagoListDto);
            GridHelper.MostrarDatosEnGrilla<ItemsDetallePagoDto>(DatosdataGridView, pagoDetalleDto.DetallesDto);
        }

        private void MostrarDatosEmpleado(PagoListDto pagoListDto)
        {
            empleadoTextBox.Text = pagoListDto.Nombre;
            fechaTextBox.Text = pagoListDto.Fecha.ToShortDateString();
            puestoTextBox.Text = pagoListDto.NombrePuesto;
            SueldotextBox.Text = pagoListDto.SueldoPorHora.ToString();
        }
    }
}
