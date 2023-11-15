using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Entidades.Enums;
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
        private List<PagoListDto> listaPago;
        private List<Pago> lista = new List<Pago>();
        int paginaActual = 1;
        int registros = 0;
        int paginas = 0;
        int registrosPorPagina = 14;
        int? EmpleadoId = null;

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
                registros = serviciosPagos.GetCantidad(EmpleadoId);
                paginas = FromHelper.CalcularPaginas(registros, registrosPorPagina);
                MostrarPaginado();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void MostrarPaginado()
        {
            listaPago = serviciosPagos.GetPagosPorPagina(registrosPorPagina, paginaActual,EmpleadoId);
            MostrarDatosEnGrilla();
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
            Registroslabel.Text = registros.ToString();
            PaginaActuallabel.Text = paginaActual.ToString();
            Paginaslabel.Text = paginas.ToString();
        }

        private EstadoPago estadoPago;
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
                estadoPago = EstadoPago.Impago;
                RecargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            PagoListDto pagoDto = (PagoListDto)r.Tag;

            try
            {
                DialogResult dr = MessageBox.Show("desea borrar el registro?", "mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                PagoListDto pago = serviciosPagos.GetPagoPorId(pagoDto.PagoId);

                if (!serviciosPagos.EstaRelacionado(pago))
                {
                    serviciosPagos.Borrar(pagoDto.PagoId);
                    GridHelper.QuitarFila(DatosdataGridView, r);
                    MessageBox.Show("registro borrado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("pago Relacionado!", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            PagoListDto PagoDto = (PagoListDto)r.Tag;
            PagoListDto pagoDtoCopia = (PagoListDto)PagoDto.Clone();
            Pago pago = serviciosPagos.GetPagosPorId(PagoDto.PagoId);

            try
            {
                FrmPagoAE frm = new FrmPagoAE() { Text = "Editar Pago" };
                frm.SetPago(pago);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                pago = frm.GetPago();

                serviciosPagos.Guardar(pago);
                GridHelper.Setearfila(r, pago);
                MessageBox.Show("Registro editado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();

            }
            catch (Exception ex)
            {
                GridHelper.Setearfila(r, pagoDtoCopia);
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            MostrarPaginado();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual == 1)
            {
                return;
            }
            paginaActual--;
            MostrarPaginado();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual == paginas)
            {
                return;
            }
            paginaActual++;
            MostrarPaginado();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            paginaActual = paginas;
            MostrarPaginado();
        }

        private void DetalletoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            var PagoSeleccionado = (PagoListDto)r.Tag;

            PagoDetalleDto pagoDetalleDto = serviciosPagos.GetPagoDetalle(PagoSeleccionado.PagoId);


            FrmDetallePago frm = new FrmDetallePago() { Text = "Detalle del Pago" };
            frm.SetPagoDetalle(pagoDetalleDto);
            DialogResult dr = frm.ShowDialog(this);

        }
    }
}
