using SegundoParcial.Entidades.Entidades;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmCiudadAE : Form
    {
        private Ciudad ciudad;
        public FrmCiudadAE()
        {
            InitializeComponent();
        }

        public Ciudad GetCiudad()
        {
            return ciudad;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (ciudad != null)
            {
                CiudadtextBox.Text = ciudad.NombreCiudad;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (ciudad == null)
                {
                    ciudad = new Ciudad();
                }
                ciudad.NombreCiudad = CiudadtextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(CiudadtextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(CiudadtextBox, "ingresar el nombre de la ciudad");
            }
            return valido;
        }
        public void SetCiudad(Ciudad ciudad)
        {
            this.ciudad = ciudad;
        }
    }
}
