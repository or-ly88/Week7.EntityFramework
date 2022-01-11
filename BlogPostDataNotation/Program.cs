// See https://aka.ms/new-console-template for more information

using BlogPostDataNotation;
using BlogPostDataNotation.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
Console.WriteLine("Hello, World!");

using (var ctx = new Context())
{
    ctx.Database.EnsureCreated();

    Blog blog1 = new Blog()
    {
        BlogUrl = "www.renata.it",
        Name = "myBlog",
        Author = "Renata"


    };

    var blog2 = new Blog()
    {
        BlogUrl = "www.ChiaraF.it",
        Name = "Blogcdi Chiara Ferragni",
        Author = "Chiara Ferragni"
    };

    //ctx.Blogs.Add(blog1);
    //ctx.Blogs.Add(blog2);
    ctx.SaveChanges();

    Console.WriteLine("Tutti i blog sono: ");
    foreach (var item in ctx.Blogs)
    {
        Console.WriteLine(item);
    }


}
