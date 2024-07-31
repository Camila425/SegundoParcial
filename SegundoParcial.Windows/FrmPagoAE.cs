using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Entidades.Enums;
using SegundoParcial.Windows.Helpers;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmPagoAE : Form
    {
        private Pago Pago;
        public FrmPagoAE()
        {
            InitializeComponent();
        }

        public Pago GetPago()
        {
            return Pago;
        }
        private EstadoPago estadoPago;
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (Pago == null)
                {
                    Pago = new Pago();
                }
                Pago.EmpleadoId = (int)EmpleadocomboBox.SelectedValue;
                Pago.Fecha = FechadateTimePicker.Value;
                Pago.ImporteTotal =int.Parse(ImporteTotaltextBox.Text);
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
            return valido;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboEmpleados(ref EmpleadocomboBox);
            if (Pago != null)
            {
                EmpleadocomboBox.SelectedValue = Pago.EmpleadoId;
                FechadateTimePicker.Value = Pago.Fecha;
                ImporteTotaltextBox.Text = Pago.ImporteTotal.ToString();
            }
        }

        public void SetPago(Pago pago)
        {
            this.Pago = pago;
        }
    }
}
