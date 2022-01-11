using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi.Models
{
    public class Gita
    {
        [Key]
        public int GitaID { get; set; }
        public DateTime DataDiPartenza { get; set; }

        
        //Relazione 1 a molti tra Gita e Responsabile
        public int ResponsabileID { get; set; } //Foreing key con convenzione
        public Responsabile Responsabile { get; set; } //Navigation property

        // Relazione 1 a molti tra Gita e Itinerario
        public int ItinerarioID { get; set; } //Foreing key con convenzione

        public Itinerario Itinerario { get; set; } //Navigation property

        //Relazione Molti a Molti con i partecipanti
        public ICollection<Partecipante> Partecipanti { get; set; } = new List<Partecipante>();
    }


}
