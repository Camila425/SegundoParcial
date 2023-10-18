using SegundoParcial.Datos.Interfaces;
using SegundoParcial.Datos.Repositorios;
using SegundoParcial.Entidades.Dtos.Pagos;
using SegundoParcial.Entidades.Entidades;
using SegundoParcial.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace SegundoParcial.Servicios.Servicios
{
    public class ServiciosPagos : IServiciosPagos
    {
        private readonly IRepositorioPagos repositorio;
        public ServiciosPagos()
        {
            repositorio = new RepositorioPagos();
        }

        public List<PagoDto> GetPago(int? EmpleadoId)
        {
            try
            {
                return repositorio.GetPago(EmpleadoId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Guardar(Pago pago)
        {
            try
            {
                if (pago.PagoId==0)
                {
                    repositorio.Agregar(pago);
                }
                else
                {
                    repositorio.Editar(pago);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
