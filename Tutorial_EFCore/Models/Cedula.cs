using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tutorial_EFCore.Models
{
    public class Cedula
    {
        [Key]
        public int CedulaId { get; set; }
        public string Numero { get; set; }
        public Cliente cliente { get; set; }
    }
}
