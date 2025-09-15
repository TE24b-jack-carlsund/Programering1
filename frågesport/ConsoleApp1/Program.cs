

Console.WriteLine("Välkomen till Jacks frågesport");
Console.WriteLine("1: Vilken orm är också ett programerings språk");
Console.WriteLine("a) Pyton b) Snok c) kobra");
string gissning = Console.ReadLine();
string a = "a) Pyton";
string b = "b) Snok";
string c = "c) Kobra";
int poäng = 0;



if (gissning == "a")
{
    Console.WriteLine("RÄTT!");
    poäng =+ poäng + 1;
    Console.WriteLine("Du har " + poäng + " poäng");

}
else if (gissning == "b")
{
    Console.WriteLine("FEL!");
}
else if (gissning == "c")
{
    Console.WriteLine("FEL!");
}
Console.WriteLine("2: Hur många schack pjäser finns det?");
Console.WriteLine("a) 77 b) 32 c) 24");
gissning = Console.ReadLine();

a = "a) 77";
b = "b) 32";
c = "c) 24";

if (gissning == "b")
{
    Console.WriteLine("RÄTT!");
    poäng =+ poäng + 1;
     Console.WriteLine("Du har " + poäng + " poäng");
    

}
else if (gissning == "a")
{
    Console.WriteLine("FEL!");
}
else if (gissning == "c")
{
    Console.WriteLine("FEL!");
}
Console.WriteLine("3: Hur många dagar är det på ett år?");
Console.WriteLine("a) 365 b) 364 c) 367");
gissning = Console.ReadLine();
a = "a) 365";
b = "b) 364";
c = "c) 367";

if (gissning == "a")
{
    Console.WriteLine("RÄTT!");
    poäng =+ poäng + 1;
     Console.WriteLine("Du har " + poäng + " poäng");
}
else if (gissning == "b")
{
    Console.WriteLine("FEL!");
}
else if (gissning == "c")
{
    Console.WriteLine("FEL!");
}

Console.WriteLine("Du fick totalt " + poäng + " poäng");
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







