using SegundoParcial.Entidades.Dtos.PagoDetalleDto;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Entidades.Enums;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        int registrosPorPagina = 10;
        int? EmpleadoFiltro = null;
        bool filtroOn = false;
        private PagoListDto pago = new PagoListDto();

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
                registros = serviciosPagos.GetCantidad(EmpleadoFiltro);
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
            listaPago = serviciosPagos.GetPagosPorPagina(registrosPorPagina, paginaActual, EmpleadoFiltro);
            MostrarDatosEnGrilla();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var pago in listaPago)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, pago);
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
                Pago pago = serviciosPagos.GetPagosPorId(pagoDto.PagoId);

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
                serviciosPagos.Editar(pago);
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

            PagoDetalleDto ItemDetalleDto = serviciosPagos.GetPagoDetalle(PagoSeleccionado.PagoId);


            FrmDetallesDelPago frm = new FrmDetallesDelPago() { Text = "Detalle del Pago" };
            frm.SetPagoDetalle(ItemDetalleDto);
            DialogResult dr = frm.ShowDialog(this);
        }

        private void BuscartoolStripButton_Click(object sender, EventArgs e)
        {
            if (!filtroOn)
            {
                FrmBuscarEmpleado frm = new FrmBuscarEmpleado() { Text = "Seleccionar Empleado" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                try
                {
                    filtroOn = true;
                    var empleado = frm.GetEmpleado();
                    EmpleadoFiltro = empleado.EmpleadoId;
                    BuscartoolStripButton.BackColor = Color.Red;
                    registros = serviciosPagos.GetCantidad(empleado.EmpleadoId);
                    paginas = FromHelper.CalcularPaginas(registros, registrosPorPagina);
                    MostrarPaginado();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Quite el filtro", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizartoolStripButton_Click(object sender, EventArgs e)
        {
            filtroOn = false;
            EmpleadoFiltro = null;
            RecargarGrilla();
            BuscartoolStripButton.BackColor = Color.White;
        }
        private void RealizarPagoEmpleadobutton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            var pago = (PagoListDto)r.Tag;

            if (pago.estadoPago == EstadoPago.Pago)
            {
                MessageBox.Show($"El pago de {pago.Nombre} ya esta pagado!",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (pago.estadoPago == EstadoPago.Anulado)
            {
                MessageBox.Show($"El pago de {pago.Nombre} Fue Anulado!",
                      "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (pago.estadoPago==EstadoPago.Impago)
            {
                FrmRealizarPago frm = new FrmRealizarPago() { Text = "pago del empleado" };
                frm.SetImporteTotal(pago.ImporteTotal);
                frm.SetNombre(pago.Nombre);
                frm.SetNombrePuesto(pago.NombrePuesto);
                frm.SetFecha(pago.Fecha);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    serviciosPagos.PagarAEmpleado(pago);
                    MessageBox.Show("Pago Realizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetearFila(r, pago);

                }
                catch (Exception)
                {
                    MessageBox.Show("Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RealizarPagoEmpleadobutton.Enabled = false;
                }
            }
        }

        private void SetearFila(DataGridViewRow r, PagoListDto pago)
        {
            r.Cells[0].Value = pago.PagoId;
            r.Cells[1].Value = pago.Nombre;
            r.Cells[2].Value = pago.Fecha.ToShortDateString();
            r.Cells[3].Value = pago.ImporteTotal;
            r.Cells[4].Value = pago.estadoPago = EstadoPago.Pago;
            if (pago.estadoPago == EstadoPago.Pago)
            {
                r.Cells[4].Style.BackColor = Color.Green;
            }
        }

        private void AnularPagotoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosdataGridView.SelectedRows[0];
            var pago = (PagoListDto)r.Tag;

            if (pago.estadoPago==EstadoPago.Pago)
            {
                MessageBox.Show($"El pago de {pago.Nombre} ya esta pagado y no puede ser anulado.",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (pago.estadoPago == EstadoPago.Anulado)
            {
                MessageBox.Show($"El pago de {pago.Nombre} ya esta anulado!",
                      "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (pago.estadoPago == EstadoPago.Impago)
            {
                DialogResult dr = MessageBox.Show($"¿Estas seguro de que quieres anular el pago de {pago.Nombre}" +
                             $" por un importe de: {pago.ImporteTotal}?", "Mensaje", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    serviciosPagos.AnularPago(pago);
                    SetearFilaParaAnular(r, pago);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void SetearFilaParaAnular(DataGridViewRow r, PagoListDto pago)
        {
            r.Cells[0].Value = pago.PagoId;
            r.Cells[1].Value = pago.Nombre;
            r.Cells[2].Value = pago.Fecha.ToShortDateString();
            r.Cells[3].Value = pago.ImporteTotal;
            r.Cells[4].Value = pago.estadoPago = EstadoPago.Anulado;
            if (pago.estadoPago == EstadoPago.Anulado)
            {
                r.Cells[4].Style.BackColor = Color.Orange;
            }
        }
    }
}
