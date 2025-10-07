using System.ComponentModel;
using System.Globalization;

Console.WriteLine("Välkommen!");
Console.WriteLine("Hur många chanser vill du ha på dig att gissa ordet [1-5]?");
string chanser = Console.ReadLine();
int i = int.Parse(chanser);
int j = 0;
// while (i > 5)
// {
//     break;
// }
while (j < i)
{
    j++;
    Console.WriteLine("Skriv din gissning:");
    string gissning = Console.ReadLine();
    string Rättsvar = "test";
    if (gissning == Rättsvar)
    {
        Console.WriteLine("Du gissade rätt");
        Console.WriteLine("Klicka ENTER för att avsluta");
        Console.ReadLine();
        break;

    }
    else if (gissning != Rättsvar)
    {
        Console.WriteLine("Nej, du gissade fel!");

    }

}


if (chanser == chanser)
{
    Console.WriteLine("Du har fölorat");
    Console.WriteLine("Klicka ENTER för att avsluta");
    Console.ReadLine();
}



