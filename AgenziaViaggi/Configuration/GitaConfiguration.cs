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
    internal class GitaConfiguration : IEntityTypeConfiguration<Gita>
    {
        public void Configure(EntityTypeBuilder<Gita> builder)
        {
            builder.ToTable("Gita");
            builder.HasKey(k => k.GitaID);
            builder.Property(d => d.DataDiPartenza).IsRequired();

            //Relazione 1 a molti tra Gita e Responsabile
            builder.HasMany(g => g.Gite)
                 .WithOne(r => r.Responsabile)
                 .HasForeignKey(r => r.ResponsabileID);

            // Relazione 1 a molti tra Gita e Itinerario
            builder.HasMany(g => g.Gite)
                 .WithOne(i => i.Itinerario)
                 .HasForeignKey(i => i.ItinerarioID);






        }









    }
}

    
   
