using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tutorial_EFCore.Models
{
    public class Recibo
    {
        [Key]
        public int ReciboId { get; set; }
        public double Monto { get; set; }
        public Cliente cliente { get; set; }

    }
}
