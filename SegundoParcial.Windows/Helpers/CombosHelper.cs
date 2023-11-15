using SegundoParcial.Entidades.Dtos.Empleados;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using SegundoParcial.Servicios.Servicios;
using System.Windows.Forms;

namespace SegundoParcial.Windows.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboTipoHorarios(ref ComboBox  combo)
        {
            IServiciosHorarios serviciosHorarios = new ServiciosHorarios();
            var lista = serviciosHorarios.GetTipoHorarios();
            var defaultHorarios= new TipoDeHorario()
            {
                TipoDeHorarioId = 0,
                TipoHorario = "Seleccione un Tipo De Horario"
            };
            lista.Insert(0, defaultHorarios);
            combo.DataSource = lista;
            combo.DisplayMember = "TipoHorario";
            combo.ValueMember = "TipoDeHorarioId";
            combo.SelectedIndex = 0;
        }

       

        public static void CargarComboPuestos(ref ComboBox combo)
        {
            IServiciosPuestos serviciosPuesto= new ServiciosPuestos();
            var listapuesto = serviciosPuesto.GetPuestos();
            var defaultPuesto = new Puesto()
            {
                PuestoId = 0,
                NombrePuesto = "Seleccione un puesto"
            };
            listapuesto.Insert(0, defaultPuesto);
            combo.DataSource = listapuesto;
            combo.DisplayMember = "NombrePuesto";
            combo.ValueMember = "PuestoId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboSectores(ref ComboBox combo)
        {
            IServiciosSectores serviciosSector = new ServiciosSectores();
            var listaSectores = serviciosSector.GetSectores();
            var defaultSectores = new Sector()
            {
                SectorId = 0,
                NombreSector = "Seleccione un Sector"
            };
            listaSectores.Insert(0, defaultSectores);
            combo.DataSource = listaSectores;
            combo.DisplayMember = "NombreSector";
            combo.ValueMember = "SectorId";
            combo.SelectedIndex = 0;
        }

       
        public static void CargarComboCiudades(ref ComboBox combo)
        {
            IServiciosCiudades servicioCiudades = new ServiciosCiudades();
            var lista = servicioCiudades.GetCiudades();
            var defaultCiudad = new Ciudad()
            {
                CiudadId = 0,
                NombreCiudad = "Seleccione una ciudad"
            };
            lista.Insert(0, defaultCiudad);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreCiudad";
            combo.ValueMember = "CiudadId";
            combo.SelectedIndex = 0;
        }

        public static void CargarComboEmpleados(ref ComboBox combo)
        {
            IServiciosEmpleados ServicioEmpleados = new ServiciosEmpleados();
            var lista = ServicioEmpleados.GetEmpleado(null,null);
            var defaultEmpleado= new EmpleadoDto()
            {
                EmpleadoId = 0,
                Nombre = "Seleccione un empleado"
            };
            lista.Insert(0, defaultEmpleado);
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "EmpleadoId";
            combo.SelectedIndex = 0;
        }

     
    }
}
