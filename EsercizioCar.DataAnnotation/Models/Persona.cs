using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCar.DataAnnotation.Models
{
    [Table("TabellaPersona")]
    public class Persona
    {
          [Key]
          public string CodiceFiscale { get; set; }

          [Required]
          public string Nome { get; set; }

          [MaxLength(20)]
          public string Cognome { get; set; }

          

        

          public DateTime DataDiNascita { get; set; }
            public ICollection<Persona> Persone { get; set; } = new List<Persona>() { };

            public override string ToString()
            {
                return $"{Nome}-{Cognome}-{CodiceFiscale}-({DataDiNascita})";

            }

        

    }
}
