using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Dtos.Horarios;
using SegundoParcial.Entidades.Dtos.ItemsDetallePago;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Entidades.Enums;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SegundoParcial.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView DatosdataGridView)
        {
            DatosdataGridView.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView DatosdataGridView)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosdataGridView);
            return r;

        }
        public static void Setearfila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Ciudad ciudad:
                    r.Cells[0].Value = ciudad.NombreCiudad;
                    break;
                case HorarioDto horario:
                    r.Cells[0].Value = horario.TipoHorario;
                    r.Cells[1].Value = horario.HoraInicio.Hours;
                    r.Cells[2].Value = horario.HoraFin.Hours;
                    break;
                case Sector sector:
                    r.Cells[0].Value = sector.NombreSector;
                    break;
                case Puesto puesto:
                    r.Cells[0].Value = puesto.NombrePuesto;
                    r.Cells[1].Value = puesto.SueldoPorHora;
                    break;
                case EmpleadoDto empleado:
                    r.Cells[0].Value = empleado.Nombre;
                    r.Cells[1].Value = empleado.Dni;
                    r.Cells[2].Value = empleado.NombrePuesto;
                    r.Cells[3].Value = empleado.NombreSector;
                    r.Cells[4].Value = empleado.FechaNacimiento.ToShortDateString();
                    break;
                case AsistenciaDto asistencia:
                    r.Cells[0].Value = asistencia.Nombre;
                    r.Cells[1].Value = asistencia.Dni;
                    r.Cells[2].Value = asistencia.Fecha.ToShortDateString();
                    r.Cells[3].Value = asistencia.HoraEntrada.ToString("hh\\:mm");
                    if (asistencia.HoraSalida.HasValue)
                    {
                        r.Cells[4].Value = asistencia.HoraSalida.Value.ToString("hh\\:mm");
                    }
                    else
                    {
                        r.Cells[4].Value = string.Empty;
                    }
                    r.Cells[5].Value = asistencia.HorasTrabajadas;
                    r.Cells[6].Value = asistencia.HorasExtras;

                    break;
                case PagoListDto pago:
                    r.Cells[0].Value = pago.PagoId;
                    r.Cells[1].Value = pago.Nombre;
                    r.Cells[2].Value = pago.Fecha.ToShortDateString();
                    r.Cells[3].Value = pago.ImporteTotal;

                    if (pago.estadoPago == EstadoPago.Impago)
                    {
                        r.Cells[4].Value = "Impago";
                        r.Cells[4].Style.BackColor = Color.Red;
                    }
                    else if (pago.estadoPago == EstadoPago.Pago)
                    {
                        r.Cells[4].Value = "Pago";
                        r.Cells[4].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        r.Cells[4].Value = "Anulado";
                        r.Cells[4].Style.BackColor = Color.Orange;
                    }

                    break;
                case ItemsDetallePagoDto ItemdetallePago:
                    r.Cells[0].Value = ItemdetallePago.SueldoPorHora;
                    r.Cells[1].Value = ItemdetallePago.HorasTrabajadas;
                    r.Cells[2].Value = ItemdetallePago.HorasExtras;
                    r.Cells[3].Value = ItemdetallePago.PrecioXHorasExtras = ItemdetallePago.SueldoPorHora;
                    r.Cells[4].Value = ItemdetallePago.Descuentos;
                    r.Cells[5].Value = ItemdetallePago.Sueldo;
                    r.Cells[6].Value = ItemdetallePago.ImporteTotal;



                    break;
            }
            r.Tag = obj;
        }
        public static void AgregarFila(DataGridView DatosdataGridView, DataGridViewRow r)
        {
            DatosdataGridView.Rows.Add(r);
        }

        public static void QuitarFila(DataGridView DatosdataGridView, DataGridViewRow r)
        {
            DatosdataGridView.Rows.Remove(r);
        }


        public static void MostrarDatosEnGrilla<T>(DataGridView DatosdataGridView, List<T> lista) where T : class
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var obj in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.Setearfila(r, obj);
                GridHelper.AgregarFila(DatosdataGridView, r);
            }

        }
    }
}
