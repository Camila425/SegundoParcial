using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Windows.Helpers;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmAsistenciaAE : Form
    {
        private Asistencia asistencia;

        public FrmAsistenciaAE()
        {
            InitializeComponent();
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (asistencia == null)
                {
                    asistencia = new Asistencia();
                }
                asistencia.empleadoId = (int)EmpleadocomboBox.SelectedValue;
                asistencia.Dni = DnitextBox.Text;
                asistencia.Fecha = FechahoydateTimePicker.Value;
                asistencia.HoraEntrada =TimeSpan.Parse(HoradateTimePicker.Value.ToShortTimeString());
                asistencia.HoraSalida = TimeSpan.Parse( HoraSalidadateTimePicker.Value.ToShortTimeString());
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (EmpleadocomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(EmpleadocomboBox, "Debe seleccionar un empleado");

            }
            //if (string.IsNullOrEmpty(DnitextBox.Text))
            //{
            //    valido = false;
            //    errorProvider1.SetError(DnitextBox, "ingresar el dni");
            //}
            return valido;

        }

        private void FrmAsistenciaAE_Load(object sender, EventArgs e)
        {
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboEmpleados(ref EmpleadocomboBox);
            if (asistencia != null)
            {
                EmpleadocomboBox.SelectedValue = asistencia.empleadoId;
                DnitextBox.Text = asistencia.Dni;
                FechadateTimePicker.Value = asistencia.Fecha;
                HoradateTimePicker.Value = DateTime.Parse(asistencia.HoraEntrada.ToString());
                HoraSalidadateTimePicker.Value = DateTime.Parse(asistencia.HoraSalida.ToString());
            }

        }
        public Asistencia GetAsistencia()
        {
            return asistencia;
        }

        public void SetAsistencia(Asistencia asistencia)
        {
            this.asistencia = asistencia;
        }
    }
}
