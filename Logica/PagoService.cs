using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System;
using Datos;
using Entidad;


namespace Logica
{
    public class PagoService
    {
        private readonly PagoContext _context;
        public PagoService(PagoContext context)
        {
            _context = context;
        }

        public PagoGuardarRespose Guardar(Pago pago)
        {
            try
            {
                _context.Pagos.Add(pago);
                _context.SaveChanges();
                return new PagoGuardarRespose(pago);
            }
            catch (Exception e)
            {
                return new PagoGuardarRespose("Error al guardar " + e.Message);
            }
        }
    }

    public class PagoGuardarRespose
    {
        public Pago Pago { get; set; }
        public string Mensaje { get; set; }

        public bool Error { get; set; }
        public PagoGuardarRespose(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
        public PagoGuardarRespose(Pago pago)
        {
            Pago = pago;
            Error = false;
        }
    }
}
