using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.EntityFramework.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>() { };

        public override string ToString()
        {
            return $"{BlogId}-{Name}-({Author})";

        }
    }
}
