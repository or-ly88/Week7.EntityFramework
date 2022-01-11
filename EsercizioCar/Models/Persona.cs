using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCar.Models
{
    public class Persona
    {
       
            public int PersonaId { get; set; }

            public string Nome { get; set; }

            public string Cognome { get; set; }

            public string CodiceFiscale { get; set; }

            public DateTime DataDiNascita { get; set; }

            public ICollection<Veicolo> Veicoli { get; set; } = new List<Veicolo>() { };

            public override string ToString()
            {
                return $"{PersonaId}-{Nome}-{Cognome}-{CodiceFiscale}-({DataDiNascita})";

            }
        
    }
}
