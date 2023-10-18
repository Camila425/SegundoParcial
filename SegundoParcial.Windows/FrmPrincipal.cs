using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmPrincipal : Form
    {
        private IconMenuItem menuActivo = null;
        private Form formularioActivo = null;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            formularioActivo = formulario;
            Contenedorpanel.Controls.Add(formulario);
            formulario.Show();

        }

        private void EmpleadosiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmEmpleados());
        }

        private void PuestosiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmPuestos());

        }

        private void SectoresiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmSectores());

        }

        private void AsistenciasiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmAsistencias());

        }

        private void HorariosiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmHorarios());

        }

        private void CiudadesiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmCiudades());

        }

        private void PagosiconMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmPagos());

        }
    }
}
