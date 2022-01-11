using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsercizioCar.FluentAPI.Models;
using EsercizioCar.FluentAPI.Configuration;

namespace EsercizioCar.FluentAPI
{
    public class Context:DbContext
    {
        public DbSet<Persona> Persone { get; set; }
        public DbSet<Veicolo> Veicoli { get; set; }
        public Context()
        {

        }

        public Context(DbContextOptions<Context> option) : base(option)
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eser.Car.FluentAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration<Persona>(new PersonaConfiguration());
            modelBuilder.ApplyConfiguration<Veicolo>(new VeicoloConfiguration());
        }
    }
}
