//Frågar i terminalen om användaren vill gå höger eller vänster
Console.WriteLine("Hej, gå vänster eller höger.");
// variabel string
string väg = Console.ReadLine();
// lagrar värdet i variabeln string som användaren skriver.
if (väg == "vänster")
{
    Console.WriteLine("Bra jobbat, du valde rätt väg!");
    Console.WriteLine("Välj en ny väg!");
    väg = Console.ReadLine();  // Läs in ett nytt värde i SAMMA variabel

    if (väg == "vänster")
    {
        Console.WriteLine("Du valde rätt väg.");
        Console.ReadLine();
    }
    else if (väg == "höger")
    {
        Console.WriteLine("Du valde fel väg");
        Console.ReadLine();
    }
}
else if (väg == "höger")
{
    Console.WriteLine("Nej, du valde fel väg");
}