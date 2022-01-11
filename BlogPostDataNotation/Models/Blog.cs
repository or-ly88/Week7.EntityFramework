using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostDataNotation.Models
{
    [Table ("TabellaBlog")]
    public class Blog
    {
      
       [Key]
       public string BlogUrl { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Author { get; set; }
         
        [NotMapped]

        public string Description { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>() { };

        public override string ToString()
        {
          return $"{BlogUrl}-{Name}-({Author})";

        }
        
    }
}
