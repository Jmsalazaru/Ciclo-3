using System;
using Microsoft.EntityFrameworkCore;
using CuidadoPorcino.App.Dominio;

namespace CuidadoPorcino.App.Persistencia
{
    public class appContext : DbContext
    {
        public DbSet<Cerdos> Cerdos { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Historia> Historia { get; set; }
        public DbSet<Visita> Visita { get; set; }
        public DbSet<Veterinario> Veterinario { get; set; }
        public DbSet<Propietario> Propietario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)// configuracion de la base de datos 

            {
                optionsBuilder
                //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=CuidadoPorcino");
                .UseSqlServer("Data Source = localhost;Database=master;User=sa;Password=Password01; Initial Catalog=CuidadoPorcino");

            }
        }
    }
}
