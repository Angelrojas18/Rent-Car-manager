using Microsoft.EntityFrameworkCore;
using RentCarManager.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCarManager.data
{
    public class RentCarManagerContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Alquiler> Alquiler { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=RentCarManagerDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder); // onModelCreating pendiente para la conversion de enums en la base de datos
        //}


        


    }
}
