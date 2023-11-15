using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Windows.Helpers;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmBuscarPuesto : Form
    {
        private Puesto PuestoSeleccionado;
        public FrmBuscarPuesto()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                PuestoSeleccionado = (Puesto)PuestocomboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (PuestocomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PuestocomboBox, " seleccionar un Puesto");
            }
            return valido;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Puesto GetPuesto()
        {
            return PuestoSeleccionado;   
        }

        private void FrmBuscarEmpleado_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboPuestos(ref PuestocomboBox);
        }
    }
}
