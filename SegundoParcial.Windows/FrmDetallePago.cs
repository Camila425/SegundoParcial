using SegundoParcial.Entidades.Dtos.DetallePgo;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmDetallePago : Form
    {
        private PagoDetalleDto pagoDetalle=new PagoDetalleDto();

        public FrmDetallePago()
        {
            InitializeComponent();

        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private List<DetallePagoDto> listaDetallePago = new List<DetallePagoDto>();

        private void DetallePago_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarDetalleDelPago(pagoDetalle.pagoListDto);
            GridHelper.MostrarDatosEnGrilla<DetallePagoDto>(DatosdataGridView, pagoDetalle.DetallesDto);

        }
        private DetallePagoDto detallePagoDto = new DetallePagoDto();
        private void MostrarDetalleDelPago(PagoListDto pago)
        {
            

            try
            {

                if (pago!=null)
                {
                    EmpleadotextBox.Text = pago.Nombre.ToString();
                    DnitextBox.Text = pago.Dni;
                    FechatextBox.Text = pago.Fecha.ToShortDateString();
                }
            }
            catch (Exception)
            {

                throw;
            }


        }
        private void OKbutton_Click(object sender, EventArgs e)
        {

        }
        public void SetPagoDetalle(PagoDetalleDto pagodetalle)
        {
            this.pagoDetalle = pagodetalle;
        }
    }
}
