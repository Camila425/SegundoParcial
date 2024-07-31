using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Entidades.Enums;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using SegundoParcial.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SegundoParcial.Windows
{
    public partial class FrmAsistencias : Form
    {
        private readonly IServiciosAsistencias servicioAsistencia;
        private readonly IServiciosPagos serviciosPagos;
        private List<AsistenciaDto> listaAsistencia;

        int paginaActual = 1;
        int registros = 0;
        int paginas = 0;
        int registrosPorPagina = 9;
        int? EmpleadoFiltro = null;
        bool filtroOn = false;

        public FrmAsistencias()
        {
            InitializeComponent();
            servicioAsistencia = new ServiciosAsistencias();
            serviciosPagos = new ServiciosPagos();
        }

        private void CerrartoolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmAsistencias_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                registros = servicioAsistencia.GetCantidad();
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
            listaAsistencia = servicioAsistencia.GetAsistenciaPorPagina(registrosPorPagina, paginaActual, EmpleadoFiltro);
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var horario in listaAsistencia)
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
            FrmAsistenciaAE frm = new FrmAsistenciaAE() { Text = "Registrar Asistencia" };
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            var asistencia = frm.GetAsistencia();

            try
            {
                //si existe una asistencia con el mismo nombre la misma fecha y todavia no registro su salida 
                // la horasalida es null no lo puedo guardar


                //if (servicioAsistencia.Existe(asistencia))
                //{
                //    MessageBox.Show("Debe registrar la salida para volver a ingresar","Mensaje", MessageBoxButtons.OK
                //        , MessageBoxIcon.Error);
                //    return;
                //}

                servicioAsistencia.Guardar(asistencia);

                //agrego el pago
                var pago = new Pago();

                pago.AsistenciaId = asistencia.AsistenciaId;
                pago.Fecha = DateTime.Now;
                pago.EstadoPago = EstadoPago.Impago;
                pago.EmpleadoId = asistencia.empleadoId;
                pago.ImporteTotal = asistencia.ImporteTotal;
                 
                serviciosPagos.Guardar(pago);

                MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            AsistenciaDto AsistenciaDto = (AsistenciaDto)r.Tag;
            AsistenciaDto AsistenciaCopia = (AsistenciaDto)AsistenciaDto.Clone();
            Asistencia asistencia = servicioAsistencia.GetAsistenciaPorId(AsistenciaDto.AsistenciaId);
            try
            {
                FrmAsistenciaAE frm = new FrmAsistenciaAE() { Text = "Registrar Retiro" };
                frm.SetAsistencia(asistencia);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                asistencia = frm.GetAsistencia();

                servicioAsistencia.Editar(asistencia);
                var pago = new Pago();

                pago.AsistenciaId = asistencia.AsistenciaId;
                pago.Fecha = DateTime.Now;
                pago.EstadoPago = EstadoPago.Impago;
                pago.EmpleadoId = asistencia.empleadoId;
                pago.ImporteTotal = asistencia.ImporteTotal;

                serviciosPagos.Editar(asistencia,pago);

                GridHelper.Setearfila(r, asistencia);
                MessageBox.Show("Salida Registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
            }
            catch (Exception ex)
            {
                GridHelper.Setearfila(r, AsistenciaCopia);
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {

            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            AsistenciaDto asistencia = (AsistenciaDto)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("desea borrar el registro?", "mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                servicioAsistencia.Borrar(asistencia.AsistenciaId);
                GridHelper.QuitarFila(DatosdataGridView, r);
                MessageBox.Show("registro borrado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void BuscartoolStripButton_Click(object sender, EventArgs e)
        {
            if (!filtroOn)
            {
                FrmBuscarEmpleado frm = new FrmBuscarEmpleado() { Text = "Seleccionar Empleado" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                try
                {
                    filtroOn = true;
                    var empleado = frm.GetEmpleado();
                    EmpleadoFiltro = empleado.EmpleadoId;
                    BuscartoolStripButton.BackColor = Color.Red;
                    registros = servicioAsistencia.GetCantidad(empleado.EmpleadoId);
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
            EmpleadoFiltro = null;
            RecargarGrilla();
            BuscartoolStripButton.BackColor = Color.White;
        }
    }
}
