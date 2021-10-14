using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Pago
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = " decima(5,2)")]
        public decimal Valor { get; set; }
        public DateTime Fecha { get; set; }
    }
}
