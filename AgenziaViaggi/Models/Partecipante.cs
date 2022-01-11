using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi.Models
{
    public class Partecipante
    {
        [Key]
        public int PartecipanteID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public string Città { get; set; }
        public string Indirizzo { get; set; }

        public string Email { get; set; }


        public ICollection<Gita> Gite { get; set; } = new List<Gita>();
    }
}
