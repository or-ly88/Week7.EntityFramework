using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCar.FluentAPI.Models
{
    public class Veicolo
    {
        public int VeicoloID { get; set; } //oppure ID o PostId

        [Key]
        public string Targa { get; set; }

        public int NumeroPosti { get; set; }

        public string Marca { get; set; }

        public DateTime DataImmatricolazione { get; set; }

        public ICollection<Persona> Persone { get; set; } = new List<Persona>() { };

        public int PersonaID { get; set; }
        public Persona Persona { get; set; }

    }
}
