// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Serialization;

int pengar = 100;

Console.WriteLine("Välkomen till butiken.");
Console.WriteLine("Vi har tomater, morötter och gurkor");

string[] choices = { "tomater", "morötter", "gurkor" };
foreach (string choice in choices)
{
    Console.WriteLine(choice);
}

