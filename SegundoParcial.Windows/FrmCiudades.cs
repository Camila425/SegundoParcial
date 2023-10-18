using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmCiudades : Form
    {
        private readonly IServiciosCiudades serviciosCiudades;
        private List<Ciudad> listaCiudad;

        int paginaActual = 1;
        int registros = 0;
        int paginas = 0;
        int registrosPorPagina = 10;
        public FrmCiudades()
        {
            InitializeComponent();
            serviciosCiudades = new ServiciosCiudades();
        }

        private void FrmCiudades_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                registros = serviciosCiudades.GetCantidad();
                paginas = FromHelper.CalcularPaginas(registros, registrosPorPagina);
                MostrarPaginado();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var ciudad in listaCiudad)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, ciudad);
                GridHelper.AgregarFila(DatosdataGridView, r);
            }
            Registroslabel.Text = registros.ToString();
            PaginaActuallabel.Text = paginaActual.ToString();
            Paginaslabel.Text = paginas.ToString();
        }

        private void MostrarPaginado()
        {
            listaCiudad = serviciosCiudades.GetCiudadesPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }

        private void CerrartoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmCiudadAE frm = new FrmCiudadAE() { Text = "nueva Ciudad" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var ciudad = frm.GetCiudad();
                if (!serviciosCiudades.Existe(ciudad))
                {
                    serviciosCiudades.Guardar(ciudad);
                    DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                    GridHelper.Setearfila(r, ciudad);
                    GridHelper.AgregarFila(DatosdataGridView, r);
                    MessageBox.Show("registro agregado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("registro Existe", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            Ciudad ciudad = (Ciudad)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("desea borrar el registro", "mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                if (!serviciosCiudades.EstaRelacionada(ciudad))
                {
                    serviciosCiudades.Borrar(ciudad.CiudadId);
                    GridHelper.QuitarFila(DatosdataGridView, r);
                    MessageBox.Show("registro borrado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("Registro Relacionado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Ciudad ciudad = (Ciudad)r.Tag;
            Ciudad CiudadCopia = (Ciudad)ciudad.Clone();
            try
            {
                FrmCiudadAE frm = new FrmCiudadAE() { Text = "editar Ciudad" };
                frm.SetCiudad(ciudad);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                ciudad = frm.GetCiudad();
                if (!serviciosCiudades.Existe(ciudad))
                {
                    serviciosCiudades.Guardar(ciudad);
                    GridHelper.Setearfila(r, ciudad);
                    MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelper.Setearfila(r, CiudadCopia);
                    MessageBox.Show("Registro Existe", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelper.Setearfila(r, CiudadCopia);
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
