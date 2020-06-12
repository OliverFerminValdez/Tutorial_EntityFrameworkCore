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

        public static void ActualizarDatos()
        {
            Contexto db = new Contexto();

            var entidad = db.Productos.Find(4);

            entidad.Descripcion = "Mango";

            db.Entry(entidad).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
