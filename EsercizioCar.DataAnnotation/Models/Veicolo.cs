using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCar.DataAnnotation.Models
{
    public class Veicolo
    {
     
            public int VeicoloId { get; set; } //oppure ID o PostId
            
           [Key]
            public string Targa { get; set; }

            public int NumeroPosti { get; set; }

            public string Marca { get; set; }

            public DateTime DataImmatricolazione { get; set; }

            //devo aggiungere il riferimento al blog

            public string Persona { get; set; } //Foreing key con convenzione

            [ForeignKey(nameof(Persona))]
            public Persona Persona { get; set; }//navigation property
        
    }
}
