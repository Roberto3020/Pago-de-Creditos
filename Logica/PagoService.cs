using System.Diagnostics.Contracts;
using System;
using Datos;
using Entidad;


namespace Logica
{
    public class PagoService
    {
        private ManejoConexion Conexion;
        private PagoRepository repository;
        public PagoService(string conexionString)
        {

            Conexion = new ManejoConexion(conexionString);
            repository = new PagoRepository(Conexion);
        }

        public PagoGuardarRespose Guardar(Pago pago)
        {
            try
            {
                Conexion.Open();
                repository.Guardar(pago);
                return new PagoGuardarRespose(pago);
            }
            catch (Exception e)
            {
                return new PagoGuardarRespose("Error al guardar " + e.Message);
            }
            finally
            {
                Conexion.Close();
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
