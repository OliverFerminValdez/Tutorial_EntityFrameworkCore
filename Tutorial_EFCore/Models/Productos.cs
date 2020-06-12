using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Tutorial_EFCore.Models
{
    public class Productos
    {
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }


    }
}
