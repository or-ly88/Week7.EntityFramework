using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCar.FluentAPI.Models
{
    public class Persona
    {
        public int PersonaID { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        [Key]
        public string CodiceFiscale { get; set; }

        public DateTime DataDiNascita { get; set; }

        public ICollection<Veicolo> Veicoli { get; set; } = new List<Veicolo>() { };

        public int VeicoloID { get; set; }

        public Veicolo Veicolo { get; set; }


        public override string ToString()
        {
            return $"{PersonaId}-{Nome}-{Cognome}-{CodiceFiscale}-({DataDiNascita})";

        }

    }
}
