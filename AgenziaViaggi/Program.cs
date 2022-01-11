// See https://aka.ms/new-console-template for more information
using AgenziaViaggi;
Console.WriteLine("Hello, World!");

using (var ctx = new Context())
{
    ctx.Database.EnsureCreated();

}
