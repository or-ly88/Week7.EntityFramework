using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.EntityFramework.Models
{
    public class Post
    {
        public int Id { get; set; } //oppure ID o PostId

        public string Text { get; set; }

        public DateTime Date { get; set; }

        //devo aggiungere il riferimento al blog

        public int BlogId { get; set; } //Foreing key con convenzione
        public Blog Blog { get; set; }//navigation property
    }
}
