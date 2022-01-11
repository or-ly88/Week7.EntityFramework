using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaViaggi.Models
{
    public class Responsabile
    {
        
        public int ResponsabileID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NumeroDiTelefono { get; set; }

        //Relazione 1 a molti tra Gita e Responsabile
        public ICollection<Gita> Gite { get; set; } = new List<Gita>();

    }
}
