using System;
using System.Collections.Generic;
using System.Text;
using Tutorial_EFCore.Models;

namespace Tutorial_EFCore.CRUD
{
    public class DataDriving
    {
        public static void GuardandoDatos()
        {
            Contexto contexto = new Contexto();

            var producto = new Productos
            {
                Descripcion = "Cerezas",
                Precio = 58
            };

            var cliente = new Cliente
            {
                Nombre = "Mario",
                Cedula = "000-000-000",
                Direccion = "VR"
            };

            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();

            contexto.Productos.Add(producto); //Añadiendo data
            contexto.SaveChanges();

        }

    }
}
