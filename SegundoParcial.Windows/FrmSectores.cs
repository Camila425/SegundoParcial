using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmSectores : Form
    {
        private readonly IServiciosSectores serviciosSectores;
        private List<Sector> listaSectores;
        int paginaActual = 1;
        int registros = 0;
        int paginas = 0;
        int registrosPorPagina = 5;
        public FrmSectores()
        {
            InitializeComponent();
            serviciosSectores = new ServiciosSectores();
        }

        private void FrmSectores_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void CerrartoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void RecargarGrilla()
        {
            try
            {
                registros = serviciosSectores.GetCantidad();
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
            listaSectores = serviciosSectores.GetSectorPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var ciudad in listaSectores)
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
            FrmSectorAE frm = new FrmSectorAE() { Text = "nuevo Sector" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var Sector = frm.GetSector();
                if (!serviciosSectores.Existe(Sector))
                {
                    serviciosSectores.Guardar(Sector);
                    DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                    GridHelper.Setearfila(r, Sector);
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

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            Sector sector = (Sector)r.Tag;
            Sector SectorCopia = (Sector)sector.Clone();
            try
            {
                FrmSectorAE frm = new FrmSectorAE() { Text = "editar Sector" };
                frm.SetSector(sector);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                sector = frm.GetSector();
                if (!serviciosSectores.Existe(sector))
                {
                    serviciosSectores.Guardar(sector);
                    GridHelper.Setearfila(r, sector);
                    MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    GridHelper.Setearfila(r, SectorCopia);
                    MessageBox.Show("Registro Existe!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelper.Setearfila(r, SectorCopia);
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
            Sector sector = (Sector)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("desea borrar el registro", "mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                if (!serviciosSectores.EstaRelacionado(sector))
                {
                    serviciosSectores.Borrar(sector.SectorId);
                    GridHelper.QuitarFila(DatosdataGridView, r);
                    MessageBox.Show("registro borrado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("registro relacionado!", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
