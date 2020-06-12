using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Tutorial_EFCore.Models;

namespace Tutorial_EFCore
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Cedula> Cedulas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server= .\SqlExpress; Database=VentaDB; Trusted_Connection=true;");
        }
    }
}
