using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tutorial_EFCore.Models
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public double TotalGeneral { get; set; }
        public ICollection<Productos> Productos { get; set; }
    }
}
