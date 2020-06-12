using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_EFCore.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }

    }
}
