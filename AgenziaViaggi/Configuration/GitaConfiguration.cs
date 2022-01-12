using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AgenziaViaggi.Models;
using AgenziaViaggi.Configuration;


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
            builder.HasOne(r => r.Responsabile)
                   .WithMany(g => g.Gite);
                 

            // Relazione 1 a molti tra Gita e Itinerario
            builder.HasOne(i=> i.Itinerario)
                   .WithMany(g => g.Gite);
                 






        }









    }
}

    
   
