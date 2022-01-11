using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCar.Models
{
    public class Veicolo
    {
        public int VeicoloId { get; set; } //oppure ID o PostId

        public string Targa { get; set; }

        public int NumeroPosti { get; set; }

        public string Marca { get; set; }

        public DateTime DataImmatricolazione { get; set; }



        //devo aggiungere il riferimento al blog

        public int PersonaId { get; set; } //Foreing key con convenzione
        public Persona Persona { get; set; }//navigation property
    }


}

