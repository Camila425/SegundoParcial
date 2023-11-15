using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Windows.Helpers;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmBuscarEmpleado : Form
    {
        private EmpleadoDto EmpleadoSeleccionado;
        public FrmBuscarEmpleado()
        {
            InitializeComponent();
        }

        public EmpleadoDto GetEmpleado()
        {
            return EmpleadoSeleccionado;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                EmpleadoSeleccionado = (EmpleadoDto)EmpleadocomboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }


        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (EmpleadocomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(EmpleadocomboBox, " seleccionar un empleado");
            }
            return valido;
        }

        private void FrmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboEmpleados(ref EmpleadocomboBox);
        }
    }
}
