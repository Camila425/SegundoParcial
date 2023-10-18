using SegundoParcial.Entidades.Entidades;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmPuestoAE : Form
    {
        private Puesto Puesto;
        public FrmPuestoAE()
        {
            InitializeComponent();
        }

        public Puesto GetPuesto()
        {
            return Puesto;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Puesto != null)
            {
                PuestotextBox.Text = Puesto.NombrePuesto;
                SueldotextBox.Text =Puesto.Sueldo.ToString();
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (Puesto == null)
                {
                    Puesto = new Puesto();
                }
                Puesto.NombrePuesto = PuestotextBox.Text;
                Puesto.Sueldo = double.Parse(SueldotextBox.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(PuestotextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(PuestotextBox, "ingresar el nombre del puesto");
            }
            if (string.IsNullOrEmpty(SueldotextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(SueldotextBox, "ingresar el Sueldo");
            }
            return valido;
        }

        public void SetPuesto(Puesto puesto)
        {
            this.Puesto = puesto;
        }
    }
}
