using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AgenziaViaggi.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi.Configuration
{
    internal class ItinerarioConfiguration : IEntityTypeConfiguration<Itinerario>
    {
        public void Configure(EntityTypeBuilder<Itinerario> builder)
        {
            builder.ToTable("Itinerario");
            builder.HasKey(k => k.ItinerarioID);
            builder.Property("Descrizione").IsRequired();
            builder.Property(d => d.Durata).IsRequired();
            builder.Property(p => p.Prezzo);

            //Relazione 1 a molti con le gite
            builder.HasMany(g => g.Gite)
                  .WithOne(i => i.Itinerario)
                  .HasForeignKey(i => i.ItinerarioID);


        }
    }
}
