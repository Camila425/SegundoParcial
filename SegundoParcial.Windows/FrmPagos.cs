using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmPagos : Form
    {
        private readonly IServiciosPagos serviciosPagos;
        private List<PagoDto> listaPago;
        public FrmPagos()
        {
            InitializeComponent();
            serviciosPagos = new ServiciosPagos();
        }

        private void CerrartoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void RecargarGrilla()
        {
            try
            {
                listaPago = serviciosPagos.GetPago(null);
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var horario in listaPago)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, horario);
                GridHelper.AgregarFila(DatosdataGridView, r);
            }
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmPagoAE frm = new FrmPagoAE() { Text = "Nuevo Pago" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var pago = frm.GetPago();
                serviciosPagos.Guardar(pago);
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, pago);
                GridHelper.AgregarFila(DatosdataGridView, r);
                MessageBox.Show("Pago agregado!!", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
