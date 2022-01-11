using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AgenziaViaggi.Models;

namespace AgenziaViaggi.Configuration
{
    internal class ResponsabileConfiguration : IEntityTypeConfiguration<Responsabile>
    {
        public void Configure(EntityTypeBuilder<Responsabile> builder)
        {

            //Entità Responsabile Gita
            builder.ToTable("Responsabile");
            builder.HasKey(r => r.ResponsabileID);
            builder.Property(r => r.ResponsabileID)
                   .HasColumnName("ID Responsabile")
                   .HasColumnOrder(0);

            builder.Property(r => r.Nome)
                   .HasColumnName("Nome")
                   .HasColumnOrder(1)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(r => r.Cognome)
                   .HasColumnName("Cognome")
                   .HasColumnOrder(2)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(r => r.NumeroDiTelefono)
                   .HasColumnName("Numero di Telefono")
                   .IsFixedLength()
                   .HasMaxLength(10)
                   .IsRequired();

            //Relazione Responsabile Gita => 1:n
            builder.HasMany(g => g.Gite)
                   .WithOne(g => g.Responsabile)
                   .HasForeignKey(g => g.ResponsabileID);

        }
    }
}
