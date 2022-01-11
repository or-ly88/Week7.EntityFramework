using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FluentAPI.Models;

namespace FluentAPI
{
    internal class EsameConfiguration : IEntityTypeConfiguration<Esame>
    {
        public void Configure(EntityTypeBuilder<Esame> builder)
        {
            //Entità esame
            builder.ToTable("Esame");
            builder.HasKey(e => e.EsameID);
            builder.Property(e => e.EsameID).HasColumnOrder(0).HasColumnName("Esame_ID");
            builder.Property(e => e.Nome).HasMaxLength(30).IsRequired();


            //Relazione studente esame => 1:n
            builder.HasOne(e => e.Studente).WithMany(s => s.Esami).HasForeignKey(s => s.StudentID).HasConstraintName("Fk_Studente");
        }
    }
}