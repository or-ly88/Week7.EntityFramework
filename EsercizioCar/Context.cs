using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EsercizioCar.Models;

namespace EsercizioCar
{
    public class Context
    {
        public class PersoneVeicoliContext : DbContext
        {
            //deve contenere er ogni entità la relativa tabella, il DBSet di Blog e di Post
            public DbSet<Persona> Persone { get; set; }
            public DbSet<Veicolo> Veicoli { get; set; }

            public PersoneVeicoliContext() : base()
            {

            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Personeveicoli;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }


        }

    }
}
