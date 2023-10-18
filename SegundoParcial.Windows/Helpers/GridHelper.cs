using SegundoParcial.Entidades.Dtos.Asistencias;
using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Dtos.Horarios;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Entidades.Enums;
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
                    r.Cells[1].Value = puesto.Sueldo;
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
                    r.Cells[3].Value = asistencia.HoraEntrada;
                    r.Cells[4].Value = asistencia.HoraSalida;
                    r.Cells[5].Value = asistencia.Estado=Estados.Asistio;
                    break;
                case PagoDto pago:
                    r.Cells[0].Value = pago.PagoId;
                    r.Cells[1].Value = pago.Nombre;
                    r.Cells[2].Value = pago.Fecha.ToShortDateString();
                    r.Cells[3].Value = pago.Importe;
                    r.Cells[4].Value = pago.estadoPago.ToString();

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
    }
}
