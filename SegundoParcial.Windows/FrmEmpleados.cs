using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmEmpleados : Form
    {
        private readonly IServiciosEmpleados serviciosempleado;
        private List<EmpleadoDto> listaEmpleado;

        int paginaActual = 1;
        int registros = 0;
        int paginas = 0;
        int registrosPorPagina = 12;
        int? PuestoFiltro=null ;
        bool filtroOn = false;

        public FrmEmpleados()
        {
            InitializeComponent();
            serviciosempleado = new ServiciosEmpleados();
        }

        private void CerrartoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void RecargarGrilla()
        {
            try
            {
                registros = serviciosempleado.GetCantidad();
                paginas = FromHelper.CalcularPaginas(registros, registrosPorPagina);
                MostrarPaginado();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void MostrarPaginado()
        {
            listaEmpleado = serviciosempleado.GetEmpleadoPorPagina(registrosPorPagina, paginaActual, PuestoFiltro);
            MostrarDatosEnGrilla();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var horario in listaEmpleado)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, horario);
                GridHelper.AgregarFila(DatosdataGridView, r);
            }
            Registroslabel.Text = registros.ToString();
            PaginaActuallabel.Text = paginaActual.ToString();
            Paginaslabel.Text = paginas.ToString();
        }


        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmEmpleadosAE frm = new FrmEmpleadosAE() { Text = "nuevo empleado" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                var empleado = frm.GetEmpleado();
                if (!serviciosempleado.Existe(empleado))
                {
                    serviciosempleado.Guardar(empleado);
                    DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                    GridHelper.Setearfila(r, empleado);
                    GridHelper.AgregarFila(DatosdataGridView, r);
                    MessageBox.Show("registro agregado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("registro Existe", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            EmpleadoDto empleadoDto = (EmpleadoDto)r.Tag;

            try
            {
                DialogResult dr = MessageBox.Show("desea borrar el registro", "mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                Empleado empleado = serviciosempleado.GetEmpleadoPorId(empleadoDto.EmpleadoId);

                if (!serviciosempleado.EstaRelacionado(empleado))
                {
                    serviciosempleado.Borrar(empleadoDto.EmpleadoId);
                    GridHelper.QuitarFila(DatosdataGridView, r);
                    MessageBox.Show("registro borrado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecargarGrilla();
                }
                else
                {
                    MessageBox.Show("Empleado Existe!", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            EmpleadoDto empleadoDto = (EmpleadoDto)r.Tag;
            EmpleadoDto empleadoDtoCopia = (EmpleadoDto)empleadoDto.Clone();
            Empleado empleado = serviciosempleado.GetEmpleadoPorId(empleadoDto.EmpleadoId);

            try
            {
                FrmEmpleadosAE frm = new FrmEmpleadosAE() { Text = "Editar Empleado" };
                frm.SetEmpleado(empleado);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                empleado = frm.GetEmpleado();
                if (!serviciosempleado.Existe(empleado))
                {
                    serviciosempleado.Guardar(empleado);
                    GridHelper.Setearfila(r, empleado);
                    MessageBox.Show("Registro editado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPaginado();
                }
                else
                {
                    GridHelper.Setearfila(r, empleadoDtoCopia);
                    MessageBox.Show("Registro Existe!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                GridHelper.Setearfila(r, empleadoDtoCopia);
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscartoolStripButton_Click(object sender, EventArgs e)
        {
            if (!filtroOn)
            {
                FrmBuscarPuesto frm = new FrmBuscarPuesto() { Text = "Seleccionar Puesto" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                try
                {
                    filtroOn = true;
                    var empleado = frm.GetEmpleado();
                    PuestoFiltro = empleado.PuestoId;
                    BuscartoolStripButton.BackColor = Color.Red;
                    registros = serviciosempleado.GetCantidad(empleado.PuestoId);
                    paginas = FromHelper.CalcularPaginas(registros, registrosPorPagina);
                    MostrarPaginado();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Quite el filtro", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizartoolStripButton_Click(object sender, EventArgs e)
        {
            filtroOn = false;
            PuestoFiltro = null;
            RecargarGrilla();
            BuscartoolStripButton.BackColor = Color.White;
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            MostrarPaginado();
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual == 1)
            {
                return;
            }
            paginaActual--;
            MostrarPaginado();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual == paginas)
            {
                return;
            }
            paginaActual++;
            MostrarPaginado();
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            paginaActual = paginas;
            MostrarPaginado();
        }
    }
}
