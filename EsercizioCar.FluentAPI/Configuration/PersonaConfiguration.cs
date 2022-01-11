using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using EsercizioCar.FluentAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCar.FluentAPI.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            //Entità Persona
            builder.ToTable("Persona");
            builder.HasKey(p => p.CodiceFiscale);
            builder.Property(p => p.Nome).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Cognome).HasMaxLength(30).IsRequired();

            //relazione persona veicolo 1:n

            builder.HasMany(v => v.Veicolo).WithOne(p => p.Persona).HasForeignKey(v => v.VeicoloID).HasConstraintName("Fk_Veicolo");
            

        }

    }
}
