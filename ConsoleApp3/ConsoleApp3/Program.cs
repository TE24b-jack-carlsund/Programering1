
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Skriv användarnamn!");
string spelare1 = Console.ReadLine();
string spelare2 = Console.ReadLine();
string startspelare = spelare1;
int hp2 = 100;
int hp1 = 100;
Console.WriteLine("Hej, välkomen till slagssmålspelet " + spelare1 + " och " + spelare2);
Console.WriteLine("Ni har 100hp, den som besegrar den andra först vinner");
int i = Random.Shared.Next(1, 3);
if (i == 2)
{
    startspelare = spelare2;

}
Console.WriteLine("Spelare " + startspelare + " tryck i för att kasta tärningen");
Console.WriteLine("");
string aktivSpelare = startspelare;
string motstandaren = spelare2;
if (aktivSpelare == spelare2)
{
     motstandaren = spelare1;
}

while (hp1 > 0 && hp2 > 0)
{
    i = Random.Shared.Next(1, 4);
    if (i == 1)
    {
        Console.WriteLine("Det händer inget");
    }
    else if (i == 2)
    {
        Console.WriteLine(aktivSpelare + " får sparka " + motstandaren);
        if (aktivSpelare == spelare1)
        {
            hp2 = hp2 - 30;
            Console.WriteLine(motstandaren + " har " + Math.Max(0,hp2) + " kvar.");
        }
        else if (aktivSpelare == spelare2)
        {
            hp1 = hp1 - 30;
            Console.WriteLine(motstandaren + " har " + Math.Max(0,hp1) + " kvar.");
        }


    }
    else if (i == 3)
    {

        Console.WriteLine(aktivSpelare + " får slå " + motstandaren);
        if (aktivSpelare == spelare1)
        {
            hp2 = hp2 - 20;
            Console.WriteLine(motstandaren + " har " + Math.Max(0,hp2) + " kvar.");
        }
        else if (aktivSpelare == spelare2)
        {
            hp1 = hp1 - 20;
            Console.WriteLine(motstandaren + " har " + Math.Max(0,hp1) + " kvar.");
        }
    }
    if (hp1 > 0 && hp2 > 0)
    {
       Console.WriteLine("Nu är det " + motstandaren + " tur att slå.");
    }
    if (aktivSpelare == spelare1)
        {
            aktivSpelare = spelare2;
            motstandaren = spelare1;
        }
        else
        {
            aktivSpelare = spelare1;
            motstandaren = spelare2;
        }
Console.WriteLine("");
}
Console.WriteLine("");
Console.WriteLine(motstandaren + " har vunnit!");
Console.ReadLine();













// Random gen = new();
// int i = Random.Shared.Next(10, 20);
// Console.WriteLine(i);
// Console.ReadLine();

// int i = 100;
// string name = "jack";
// while (i > 0 && name == "jack")
// {
//     Console.WriteLine("Hello");
//     i--;
// }

// int hitpoints = 100 + 50;
// hitpoints = hitpoints - 10;

// hitpoints -= 5;
// hitpoints--;
// hitpoints++;
// string name = "Jack";

// Console.WriteLine($"HP: {hitpoints}");
// Console.ReadLine();