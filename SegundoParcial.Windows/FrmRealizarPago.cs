using SegundoParcial.Entidades.Dtos.Pagos;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmRealizarPago : Form
    {
      
        private double ImporteTotal;
        private string nombre;
        private string NombrePuesto;
        private DateTime Fecha;

        private PagoListDto pagoDetalleDto=new PagoListDto();
        public FrmRealizarPago()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmRealizarPago_Load(object sender, EventArgs e)
        {
            ImporteAPagarLabel.Text = ImporteTotal.ToString("N2");
            ImporteAPagartextBox.Text = ImporteTotal.ToString("N2");
            DescuentotextBox.Text =((ImporteTotal/0.90)-ImporteTotal).ToString();
            SueldotextBox.Text = ((ImporteTotal / 0.90)).ToString();
            EmpleadotextBox.Text = nombre;
            PuestotextBox.Text = NombrePuesto;
            FechadateTimePicker.Text = Fecha.ToString();
        }

        public void SetImporteTotal(double importeTotal)
        {
            this.ImporteTotal = importeTotal;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void GuardarPagobutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult dr = MessageBox.Show($"¿Estas seguro de que quieres realizar el pago al empleado: {nombre} por un importe de: {ImporteTotal}?",
                    "Confirmar pago", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                }
                return;
            }
        }
            private bool ValidarDatos()
        {
            bool valido = true;
           
            return valido;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetNombrePuesto(string nombrepuesto)
        {
            this.NombrePuesto = nombrepuesto;
        }

        public void SetFecha(DateTime fecha)
        {
            this.Fecha = fecha;
        }
    }
}
