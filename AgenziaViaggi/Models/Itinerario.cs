using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi.Models
{
    public class Itinerario
    {
        
        public int ItinerarioID { get; set; }
        public string Descrizione { get; set; }
        public int Durata { get; set; }
        public decimal Prezzo { get; set; }

        //Relazione 1 a molti con le gite
        public ICollection<Gita> Gite { get; set; } = new List<Gita>();
    }
}
