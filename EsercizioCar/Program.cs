// See https://aka.ms/new-console-template for more information

using EsercizioCar;
using EsercizioCar.Models;
using static EsercizioCar.Context;
Console.WriteLine("Hello, World!");


using (var ctx = new PersoneVeicoliContext())
{
    ctx.Database.EnsureCreated();

    //inserire un blog

    Veicolo veicolo1 = new Veicolo()
    {
        Targa = "GM567HY",
        NumeroPosti = 5,
        Marca="Nissan",
        DataImmatricolazione=new DateTime (2020/08/08),


    };

    var veicolo2 = new Veicolo()
    {
        Targa = "FT897PL",
        NumeroPosti = 5,
        Marca = "Fiat",
        DataImmatricolazione = new DateTime(2018 / 05 / 02),

    };

    ctx.Veicoli.Add(veicolo1);
    ctx.Veicoli.Add(veicolo2);
    ctx.SaveChanges();

    //faccio un foreach di tutto
    Console.Write("Tutti i veicoli sono: ");

    foreach (var item in ctx.Veicoli)
    {
        Console.WriteLine(item.Targa);
    }

    //recuperare i dati da una tabella
    Console.Write("I blog della Ferragni sono: ");
    var blogFerragni = ctx.Veicoli.Where(v => v.Targa.Contains("F"));

    foreach (var item in blogFerragni)
    {
        Console.WriteLine(item.Nome);
    }

    var myVeicolo = ctx.Veicoli.Find(1);
    var veicolo = AddPersona(Persona);
    ctx.Veicoli.Add(Veicolo);
    ctx.SaveChanges();
}

static Persona AddPersona(Veicolo selectedVeicolo)
{
    Persona post = new Persona()
    {
        Nome = "Sara",
        Cognome = "Rossi",
        CodiceFiscale = "RSSSRA88F50GD869W",
        DataDiNascita= new DateTime (1950-07-09),

    };
}


