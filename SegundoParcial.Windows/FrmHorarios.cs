using SegundoParcial.Entidades.Dtos.Horarios;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmHorarios : Form
    {
        private readonly IServiciosHorarios servicioHorario;
        private List<HorarioDto> listaHorario;

        int paginaActual = 1;
        int registros = 0;
        int paginas = 0;
        int registrosPorPagina = 5;
        int? TipoHorario = null;

        public FrmHorarios()
        {
            InitializeComponent();
            servicioHorario = new ServiciosHorarios();
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                registros = servicioHorario.GetCantidad();
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
            listaHorario = servicioHorario.GetHorarioPorPagina(registrosPorPagina, paginaActual, TipoHorario);
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var horario in listaHorario)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, horario);
                GridHelper.AgregarFila(DatosdataGridView, r);
            }
            Registroslabel.Text = registros.ToString();
            PaginaActuallabel.Text = paginaActual.ToString();
            Paginaslabel.Text = paginas.ToString();
        }



        private void CerrartoolStripButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmHorarioAE frm = new FrmHorarioAE() { Text = "nuevo Horario" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var Horario = frm.GetHorario();
                if (!servicioHorario.Existe(Horario))
                {
                    servicioHorario.Guardar(Horario);
                    DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                    GridHelper.Setearfila(r, Horario);
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

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            HorarioDto horario = (HorarioDto)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("desea borrar el registro?", "mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                servicioHorario.Borrar(horario.HorarioId);
                GridHelper.QuitarFila(DatosdataGridView, r);
                MessageBox.Show("registro borrado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
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
            HorarioDto HorarioDto = (HorarioDto)r.Tag;
            HorarioDto HorarioCopia = (HorarioDto)HorarioDto.Clone();
            Horario Horario = servicioHorario.GetHorarioPorId(HorarioDto.HorarioId);

            try
            {
                FrmHorarioAE frm = new FrmHorarioAE() { Text = "editar horario" };
                frm.SetHorario(Horario);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                Horario = frm.GetHorario();
                if (!servicioHorario.Existe(Horario))
                {
                    servicioHorario.Guardar(Horario);
                    GridHelper.Setearfila(r, Horario);
                    MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    GridHelper.Setearfila(r, HorarioCopia);
                    MessageBox.Show("Registro Existe", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelper.Setearfila(r, HorarioCopia);
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
