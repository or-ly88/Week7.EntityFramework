// See https://aka.ms/new-console-template for more information
using Week7.EntityFramework.Models;
Console.WriteLine("Hello, World!");

using (var ctx = new PersoneVeicoliContext())
{
    ctx.Database.EnsureCreated();

    //inserire una persona

    Persona persona1 = new Persona()
    {
        Nome = "Chiara",
        Cognome = "Bianchi",
        CodiceFiscale="BNCCHR56T78849P",
        DataDiNascita= new DateTime (1956-01-22),
        
    };

    var persona2 = new Persona()
    {
        Nome = "Rebecca",
        Cognome = "Verdi",
        CodiceFiscale = "VRDRBB88S70F839Q",
        DataDiNascita = new DateTime(1988 - 11 - 30),

    };

    ctx.Persone.Add(persona1);
    ctx.Persone.Add(persona2);
    ctx.SaveChanges();

    //faccio un foreach di tutto
    Console.Write("Tutte le persone sono: ");
    
        foreach (var item in ctx.Blogs)
        {
          Console.WriteLine(item.Nome);
        }

    //recuperare i dati da una tabella
    Console.Write("I veicoli sono: ");
    var blogFerragni = ctx.Blogs.Where(blog => blog.Author.Contains("Ferragni"));

    foreach (var item in blogFerragni)
    {
        Console.WriteLine(item.Name);
    }

    var myBlog = ctx.Blogs.Find(1);
    var post=AddPost(myBlog);
    ctx.Posts.Add(post);
    ctx.SaveChanges();
}

static Post AddPost(Blog selectedBlog)
{
    Post post = new Post()
    {
        Text = "New Post per il mio blog",
        Date = DateTime.Now,
        Blog = selectedBlog

    };
}

