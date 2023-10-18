using SegundoParcial.Entidades.Entidades;
using System;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmSectorAE : Form
    {
        private Sector sector;
        public FrmSectorAE()
        {
            InitializeComponent();
        }

        public Sector GetSector()
        {
            return sector;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (sector != null)
            {
                SectortextBox.Text = sector.NombreSector;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (sector == null)
                {
                    sector = new Sector();
                }
                sector.NombreSector = SectortextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(SectortextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(SectortextBox, "ingresar el nombre del Sector");
            }
            return valido;
        }

        public void SetSector(Sector sector)
        {
            this.sector = sector;
        }
    }
}
