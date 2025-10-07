

int plånbok = 100;
int prisyxa = 30;
int prissten = 10;
int prisäpple = 5;
string val1 = "1) yxa";
string val2 = "2) sten";
string val3 = "3) äpple";
Console.WriteLine("Välkomen till affären, det finns tre varor.");
 string produkt = Console.ReadLine();
while (plånbok > 0)
{
    Console.WriteLine("Välg en av dessa");
    Console.WriteLine("1) yxa ");
    Console.WriteLine("2) sten");
    Console.WriteLine("3) äpple");
    Console.ReadLine();
    if (produkt == val1)
    {
        plånbok = plånbok - prisyxa;
        Console.WriteLine("Du har nu " + plånbok + " kr " + " kvar ");
    }
    else if (produkt == val2)
    {
        plånbok = plånbok - prissten;
        Console.WriteLine("Du har nu " + plånbok + " kr " + " kvar ");
    }
    else if (produkt == val3)
    {
        plånbok = plånbok - prisäpple;
        Console.WriteLine("Du har nu " + plånbok + " kr " + " kvar ");
    }
}
Console.ReadLine();




// using System.ComponentModel;

// bool success = false;
// while (success == false)
// {
//     Console.WriteLine("Skriv en siffra:");
//     string s = Console.ReadLine();
//     success = int.TryParse(s, out siffra);
// }

// Console.WriteLine("Skriv en siffra:");
// string s = Console.ReadLine();
// int siffra;


// Console.WriteLine(siffra*2);
// // parse tar in en string och gör om den till en siffra.