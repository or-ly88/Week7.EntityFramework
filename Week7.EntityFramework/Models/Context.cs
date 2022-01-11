using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.EntityFramework.Models
{
    public class BlogPostContext :DbContext
    {
        //deve contenere er ogni entità la relativa tabella, il DBSet di Blog e di Post
        public DbSet<Post> Posts { get; set; }
        public  DbSet<Blog> Blogs { get;set; }

        public BlogPostContext() : base()
        { 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlogPost;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


    }
}
