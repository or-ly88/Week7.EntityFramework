using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Models
{
    internal class Studente
    {
        public int StudenteID { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        public DateTime? DataDiNascita { get; set; }

        public ICollection<Esame> Esami { get; set; } = new List<Esame>();

    }
}
