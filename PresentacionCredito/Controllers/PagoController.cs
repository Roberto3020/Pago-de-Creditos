using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datos;
using Entidad;
using Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PresentacionCredito.Models;

namespace PresentacionCredito.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagoController : ControllerBase
    {
        private readonly PagoService pagoService;

            public PagoController(PagoContext context)
            {
                pagoService = new PagoService(context);
            }

            //  configuracion = configuration;
            // string connectionString = configuracion["ConnectionStrings:DefaultConnection"];
            // pagoService = new PagoService(connectionString);
        
        // [HttpPost]
        // public ActionResult<Pago> Guardar(PagoInputModel pagoInput)
        // {
        //     var pago = new Pago();
        //     pago.Valor = pagoInput.Valor;
        //     pago.Fecha = pagoInput.Fecha;
        //      var repuesra =pagoService.Guardar(pago);
        //      if(repuesra.Error)
        //      {
        //          return BadRequest (repuesra.Mensaje);
        //      }
        //      return  Ok(pago);
        // }

    }
}