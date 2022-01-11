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
    public class VeicoloConfiguration : IEntityTypeConfiguration<Veicolo>
    {
        public void Configure(EntityTypeBuilder<Veicolo> builder)
        {
            //Entità Veicolo
            builder.ToTable("Veicolo");
            builder.HasKey(v => v.Targa);
            builder.Property(v => v.VeicoloID).HasColumnOrder(0).HasColumnName("Veicolo_ID");
            builder.Property(v => v.Marca).HasMaxLength(30).IsRequired();

            //relazione persona veicolo

            builder.HasOne(v => v.Veicolo).WithOne(p => p.Persona).HasForeignKey(e => e.PersonaID);


        }
    }


}
