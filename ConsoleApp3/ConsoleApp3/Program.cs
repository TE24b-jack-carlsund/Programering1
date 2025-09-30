
using System.ComponentModel.DataAnnotations;


// Console.WriteLine("Skriv användarnamn!");
// string spelare1 = Console.ReadLine();
// string spelare2 = Console.ReadLine();
Console.WriteLine("Välkommen till fighting spelet, spelare1 tryck n för att få ditt namn.");
string spelare1 = "";
int n = Random.Shared.Next(0, 3);
 spelare1 = Console.ReadLine();
if (n == 1)
{
    spelare1 = "jack";
    Console.WriteLine("Spelare1 heter " + spelare1);
}
else if (n == 2)
{
    spelare1 = "Noel";
    Console.WriteLine("Spelare1 heter " + spelare1);
}
else if (n == 0)
{
    spelare1 = "Jak";
    Console.WriteLine("Spelare1 heter " + spelare1);
}
Console.WriteLine("Spelare2, välj ditt namn.");
string spelare2 = "";
spelare2 = Console.ReadLine();
Console.WriteLine("spelare2 heter " + spelare2);
Console.WriteLine("Ni heter " + spelare1 + " och " + spelare2);

string startspelare = spelare1;
int hp2 = 100;
int hp1 = 100;
string satsning1 = Console.ReadLine();
string satsning2 = Console.ReadLine();
int pengarSpelare1 = 1000;
int pengarSpelare2 = 1000;

Console.WriteLine("Hej, välkomen till slagssmålspelet " + spelare1 + " och " + spelare2);
Console.WriteLine("Ni har 100hp, den som besegrar den andra först vinner");
Console.WriteLine(spelare1 + " välj vem du vill satsa på och hur mycket?");
Console.ReadLine();
Console.WriteLine(spelare2 + "välj vem du vill satsa på och hur mycket?")
Console.ReadLine();
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

if (satsning1 == motstandaren)
{
    Console.WriteLine("Grattis, du satsade på rätt person");
}
else if (satsning1 == aktivSpelare)
{
    Console.WriteLine("Synd, du satsade på fel spelare?");
}


if (satsning2 == motstandaren)
{
    Console.WriteLine("Grattis, du satsade på rätt person");
}
else if (satsning2 == aktivSpelare)
{
    Console.WriteLine("Synd, du satsade på fel spelare?");
}











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

