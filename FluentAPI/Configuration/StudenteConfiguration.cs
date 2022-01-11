using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FluentAPI.Models;

namespace FluentAPI
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Studente>
    {
        public void Configure(EntityTypeBuilder<Studente> builder)
        {
            //Entità Studente
            builder.ToTable("Studente");
            builder.HasKey(e => e.StudenteID);
            builder.Property(e => e.Cognome).IsRequired();
            builder.Property(e => e.Nome).IsRequired();

            //relazione studente esame => 1:n

            builder.HasMany(e => e.Esami).WithOne(e => e.Studente).HasForeignKey(e => e.StudentID);
        }
    }
}