using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmPuestos : Form
    {
        private readonly IServiciosPuestos serviciosPuestos;
        private List<Puesto> listaPuestos;

        int paginaActual = 1;
        int registros = 0;
        int paginas = 0;
        int registrosPorPagina = 12;
        public FrmPuestos()
        {
            InitializeComponent();
            serviciosPuestos = new ServiciosPuestos();
        }

        private void CerrartoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                registros = serviciosPuestos.GetCantidad();
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
            listaPuestos = serviciosPuestos.GetPuestoPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var ciudad in listaPuestos)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, ciudad);
                GridHelper.AgregarFila(DatosdataGridView, r);
            }
            Registroslabel.Text = registros.ToString();
            PaginaActuallabel.Text = paginaActual.ToString();
            Paginaslabel.Text = paginas.ToString();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmPuestoAE frm = new FrmPuestoAE() { Text = "nuevo puesto" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var Puesto = frm.GetPuesto();
                if (!serviciosPuestos.Existe(Puesto))
                {
                    serviciosPuestos.Guardar(Puesto);
                    DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                    GridHelper.Setearfila(r, Puesto);
                    GridHelper.AgregarFila(DatosdataGridView, r);
                    MessageBox.Show("registro agregado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("registro Existe!", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            Puesto Puesto = (Puesto)r.Tag;
            Puesto PuestoCopia = (Puesto)Puesto.Clone();
            try
            {
                FrmPuestoAE frm = new FrmPuestoAE() { Text = "editar puesto" };
                frm.SetPuesto(Puesto);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                Puesto = frm.GetPuesto();
                if (!serviciosPuestos.Existe(Puesto))
                {
                    serviciosPuestos.Guardar(Puesto);
                    GridHelper.Setearfila(r, Puesto);
                    MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelper.Setearfila(r, PuestoCopia);
                    MessageBox.Show("Registro Existe!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelper.Setearfila(r, PuestoCopia);
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            Puesto puesto = (Puesto)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("desea borrar el registro", "mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                if (!serviciosPuestos.EstaRelacionado(puesto))
                {
                    serviciosPuestos.Borrar(puesto.PuestoId);
                    GridHelper.QuitarFila(DatosdataGridView, r);
                    MessageBox.Show("registro borrado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("registro relacionado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            MostrarPaginado();
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual == 1)
            {
                return;
            }
            paginaActual--;
            MostrarPaginado();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual == paginas)
            {
                return;
            }
            paginaActual++;
            MostrarPaginado();
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            paginaActual = paginas;
            MostrarPaginado();
        }
    }
}
