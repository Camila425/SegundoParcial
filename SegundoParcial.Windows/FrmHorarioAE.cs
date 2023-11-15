using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Windows.Helpers;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmHorarioAE : Form
    {
        private Horario Horario;
        public FrmHorarioAE()
        {
            InitializeComponent();
        }

        public Horario GetHorario()
        {
            return Horario; 
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (Horario == null)
                {
                    Horario = new Horario();
                }
                Horario.tipoHorario = (TipoDeHorario)HorariocomboBox.SelectedItem;
                Horario.TipoDeHorarioId = (int)HorariocomboBox.SelectedValue;

                Horario.HoraInicio = HoraIniciodateTimePicker.Value.TimeOfDay;
                Horario.HoraFin = HoraSalidadateTimePicker.Value.TimeOfDay;
                DialogResult = DialogResult.OK;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboTipoHorarios(ref HorariocomboBox);

            if (Horario != null)
            {
                HorariocomboBox.SelectedValue = Horario.HorarioId;

                HoraIniciodateTimePicker.Value = DateTime.Parse(Horario.HoraInicio.ToString());
                HoraSalidadateTimePicker.Value = DateTime.Parse(Horario.HoraFin.ToString());

            }
        }

        private bool validarDatos()
        {
            bool Valido = true;
            if (HorariocomboBox.SelectedIndex == 0)
            {
                Valido = false;
                errorProvider1.SetError(HorariocomboBox, "Debe seleccionar un turno");
            }
            if (string.IsNullOrEmpty(HoraIniciodateTimePicker.Text))
            {
                Valido = false;
                errorProvider1.SetError(HoraIniciodateTimePicker, "ingrese el horario de entrada");
            }
            if (string.IsNullOrEmpty(HoraSalidadateTimePicker.Text))
            {
                Valido = false;
                errorProvider1.SetError(HoraSalidadateTimePicker, "ingrese el horario de salida");
            }
            return Valido;
        }

        public void SetHorario(Horario horario)
        {
            this.Horario = horario;
        }

    }
}
