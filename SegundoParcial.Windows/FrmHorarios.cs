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
                listaHorario = servicioHorario.GetHorarios(null);
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {
                throw;
            }
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
    }
}
