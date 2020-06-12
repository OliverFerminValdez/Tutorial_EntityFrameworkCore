using System;
using Tutorial_EFCore.Models;

namespace Tutorial_EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var contexto = new Contexto())
            {
                var producto = new Productos
                {
                    Descripcion = "Manzanas",
                    Precio = 40
                };

                contexto.Productos.Add(producto);
                contexto.SaveChanges();

            }
        }
    }
}
