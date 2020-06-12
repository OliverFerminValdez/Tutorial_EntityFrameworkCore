using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
                    Descripcion = "Piñas",
                    Precio = 58
                };

                    var cliente = new Cliente
                    {
                        Nombre = "Pedro",
                        Cedula = "000-000-000",
                        Direccion = "Castillo"
                    };

                contexto.Productos.Add(producto); //Añadiendo data
                contexto.SaveChanges();

                //Consultando

                var consulta = contexto.Productos.Where(p => p.Descripcion == "Peras").ToList();
                var consulta2 = contexto.Productos.ToList();
                
                Console.WriteLine("\n");
                foreach (var item in consulta)
                {
                    Console.WriteLine("Descripcion: " + item.Descripcion + " Precio: " + item.Precio);
                }
                Console.WriteLine("\n");
                Console.WriteLine("\n");

                foreach (var item in consulta2)
                {
                    Console.WriteLine("Descripcion: " + item.Descripcion + " Precio: " + item.Precio);
                }
                //Actualizando datos

            }
        }
    }
}
