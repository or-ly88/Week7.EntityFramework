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
    internal class PartecipanteConfiguration : IEntityTypeConfiguration<Partecipante>
    {
        public void Configure(EntityTypeBuilder<Partecipante> builder)
        {
            builder.ToTable("Partecipante");
            builder.HasKey(k => k.PartecipanteID);
            builder.Property("Nome").IsRequired();
            builder.Property(c => c.Cognome).IsRequired();
            builder.Property(i => i.Indirizzo).HasMaxLength(50)
                                              .IsRequired();
            builder.Property(c => c.Città).IsRequired();
            builder.Property(d => d.DataDiNascita).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(50);

        }
    }
}
