using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Windows.Helpers;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmEmpleadosAE : Form
    {
        public FrmEmpleadosAE()
        {
            InitializeComponent();
        }
        private Empleado empleado;
        public Empleado GetEmpleado()
        {
            return empleado;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboPuestos(ref PuestocomboBox);
            CombosHelper.CargarComboSectores(ref SectorcomboBox);
            CombosHelper.CargarComboTipoHorarios(ref HorariocomboBox);
            CombosHelper.CargarComboCiudades(ref CiudadcomboBox);

            if (empleado!=null)
            {
                EmpleadotextBox.Text = empleado.Nombre;
                FechaNacimientodateTimePicker.Value = empleado.FechaNacimiento;
                DnitextBox.Text = empleado.Dni;
                DirecciontextBox.Text = empleado.Direccion;
                HorariocomboBox.SelectedValue = empleado.HorarioId;
                CiudadcomboBox.SelectedValue = empleado.CiudadId;
                PuestocomboBox.SelectedValue = empleado.PuestoId;
                SectorcomboBox.SelectedValue = empleado.SectorId;
            }
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (empleado == null)
                {
                    empleado = new Empleado();
                }
                empleado.Nombre = EmpleadotextBox.Text;
                empleado.FechaNacimiento = FechaNacimientodateTimePicker.Value;
                empleado.Dni = DnitextBox.Text;
                empleado.Direccion = DirecciontextBox.Text;
                empleado.HorarioId = (int)HorariocomboBox.SelectedValue;
                empleado.CiudadId = (int)CiudadcomboBox.SelectedValue;
                empleado.PuestoId = (int)PuestocomboBox.SelectedValue;
                empleado.SectorId = (int)SectorcomboBox.SelectedValue;
                DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(EmpleadotextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(EmpleadotextBox, "ingresar el nombre del empleado");
            }
            if (string.IsNullOrEmpty(DnitextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(DnitextBox, "ingresar el dni del empleado");
            }
            if (PuestocomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PuestocomboBox, "Debe seleccionar un puesto de trabajo");

            }
            if (SectorcomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(SectorcomboBox, "Debe seleccionar un sector");

            }
            if (HorariocomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(HorariocomboBox, "Debe seleccionar un Horario");

            }
            if (CiudadcomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CiudadcomboBox, "Debe seleccionar una ciudad");

            }
            return valido;
        }
        public void SetEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }
    }
}
