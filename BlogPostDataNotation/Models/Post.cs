using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostDataNotation.Models
{
    public class Post
    {
        public int Id { get; set; } //oppure ID o PostId

        public string Text { get; set; }

        public DateTime Date { get; set; }

        //devo aggiungere il riferimento al blog

        public string BlogUrl { get; set; } //Foreing key con convenzione
        
        [ForeignKey (nameof(BlogUrl))]
        public Blog Blog { get; set; }//navigation property
    }
}
