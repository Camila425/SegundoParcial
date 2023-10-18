using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmAsistencias : Form
    {
        private readonly IServiciosAsistencias servicioAsistencia;
        private List<AsistenciaDto> listaAsistencia;

        int paginaActual = 1;
        int registros = 0;
        int paginas = 0;
        int registrosPorPagina = 12;
        int? EmpleadoFiltro = null;
       

        public FrmAsistencias()
        {
            InitializeComponent();
            servicioAsistencia = new ServiciosAsistencias();
        }

        private void CerrartoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmAsistencias_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                registros = servicioAsistencia.GetCantidad();
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
            listaAsistencia = servicioAsistencia.GetAsistenciaPorPagina(registrosPorPagina, paginaActual,EmpleadoFiltro);
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var horario in listaAsistencia)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, horario);
                GridHelper.AgregarFila(DatosdataGridView, r);
            }
            Registroslabel.Text = registros.ToString();
            PaginaActuallabel.Text = paginaActual.ToString();
            Paginaslabel.Text = paginas.ToString();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmAsistenciaAE frm = new FrmAsistenciaAE() { Text = "Registrar Asistencia" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var asistencia = frm.GetAsistencia();
                servicioAsistencia.Guardar(asistencia);
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, asistencia);
                GridHelper.AgregarFila(DatosdataGridView, r);
                MessageBox.Show("registro agregado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
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
            AsistenciaDto AsistenciaDto = (AsistenciaDto)r.Tag;
            AsistenciaDto AsistenciaCopia = (AsistenciaDto)AsistenciaDto.Clone();
            Asistencia asistencia = servicioAsistencia.GetAsistenciaPorId(AsistenciaDto.AsistenciaId);
            try
            {
                FrmAsistenciaAE frm = new FrmAsistenciaAE() { Text = "Registrar Retiro" };
                frm.SetAsistencia(asistencia);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                asistencia = frm.GetAsistencia();
                
                    servicioAsistencia.Guardar(asistencia);
                    GridHelper.Setearfila(r, asistencia);
                    MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
            }
            catch (Exception ex)
            {
                GridHelper.Setearfila(r, AsistenciaCopia);
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
            AsistenciaDto asistencia = (AsistenciaDto)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("desea borrar el registro?", "mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                servicioAsistencia.Borrar(asistencia.AsistenciaId);
                GridHelper.QuitarFila(DatosdataGridView, r);
                MessageBox.Show("registro borrado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
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
