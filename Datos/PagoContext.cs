using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidad;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class PagoContext:DbContext
    {
        public PagoContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Pago> Pagos{get;set;}
    }
}