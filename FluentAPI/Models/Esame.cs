using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Models
{
    internal class Esame
    {
        public int EsameID { get; set; }
        public string Nome { get; set; }
        public int? CFU { get; set; }
        public int? Votazioe { get; set; }
        public bool Passato { get; set; } = false;
        public int StudentID { get; set; }
        public Studente Studente { get; set; }
    }
}

