using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using FluentAPI.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    internal class Context : DbContext
    {
        public DbSet<Studente> Studenti { get; set; }
        public DbSet<Esame> Esami { get; set; }
        public Context()
        {

        }

        public Context(DbContextOptions<Context> option) : base(option)
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudenteEsame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration<Esame>(new EsameConfiguration());
            modelBuilder.ApplyConfiguration<Studente>(new StudenteConfiguration());

            ////Entità esame
            //modelBuilder.Entity<Esame>(e => e.ToTable("Esame"));//rinominare la tabella
            //modelBuilder.Entity<Esame>(e => e.HasKey(e => e.EsameID));
            //modelBuilder.Entity<Esame>(e => e.Property(e => e.EsameID).HasColumnOrder(0).HasColumnName("StudenteID"));
            //modelBuilder.Entity<Esame>(e => e.Property(e => e.Nome).HasMaxLength(30));
            //modelBuilder.Entity<Esame>(e => e.Property(e => e.Nome).HasMaxLength(30).IsRequired());


            ////Relazione studente esame => 1:n
            //modelBuilder.Entity<Esame>(e => e.HasOne(e => e.Studente).WithMany(s => s.Esami).HasForeignKey(s => s.StudentID).HasConstraintName("FK_"));

            ////Entità Studente
            //modelBuilder.Entity<Studente>(e => e.ToTable("Studente"));
            //modelBuilder.Entity<Studente>(e => e.HasKey(e => e.StudenteID));
            //modelBuilder.Entity<Studente>(e => e.Property(e => e.Cognome).IsRequired());
            //modelBuilder.Entity<Studente>(e => e.Property(e => e.Nome).IsRequired());


            ////relazione studente esame =>1:m
            //modelBuilder.Entity<Studente>(e => e.HasMany(e => e.Esami).WithOne(e => e.Studente).HasForeignKey(e => e.StudenteID));

        }
        
    }
    
}
