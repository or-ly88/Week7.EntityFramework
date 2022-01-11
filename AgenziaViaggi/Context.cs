using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using AgenziaViaggi.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Responsabile
            modelBuilder.ApplyConfiguration<Partecipante>().ToTable("Responsabile")
                                                           .HasKey(K => K.ID);
            modelBuilder.Entity<Responsabile>().Property("Nome").IsRequired();
            modelBuilder.Entity<Responsabile>().Property("Cognome").IsRequired();
            modelBuilder.Entity<Responsabile>().Property("NumeroDiTelefono")
                                               .IsFixedLength()
                                               .HasMaxLength(10)
                                               .IsRequired();

            //Itinerario

                                               

        }

       
    }
}
