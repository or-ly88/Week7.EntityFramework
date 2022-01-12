using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using AgenziaViaggi.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenziaViaggi.Configuration;

namespace AgenziaViaggi
{
    public class Context : DbContext
    {
        
          public DbSet<Partecipante> Partecipanti { get; set; }

          public DbSet<Gita> Gite { get; set; }

            public Context() : base()
            {
            
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgenziaViaggiEF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Partecipante
            modelBuilder.ApplyConfiguration<Partecipante>(new PartecipanteConfiguration());
            //Gita
            modelBuilder.ApplyConfiguration<Gita>(new GitaConfiguration());
            //Itinerario
            modelBuilder.ApplyConfiguration<Itinerario>(new ItinerarioConfiguration());
            //Responsabile
            modelBuilder.ApplyConfiguration<Responsabile>(new ResponsabileConfiguration());


        }

       
    }
}
