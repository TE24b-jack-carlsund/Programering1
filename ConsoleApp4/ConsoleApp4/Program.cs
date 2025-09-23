// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello and welcome to our quiz");
Console.WriteLine("Chose between a to c");
Console.WriteLine("1: Which city is in Japan?");
Console.WriteLine("a) kagoshima b) stockholm c) New york");

string a = "a";
string b = "b";
string c = "c";
int point = 0;
string player = Console.ReadLine();
if (player == a)
{
    Console.WriteLine("All right");
    point += 1;



}
else if (player == b)
{
    Console.WriteLine("Bad");
    point -= 1;

}
else if (player == c)
{
    Console.WriteLine("Bad");
    point -= 1;
}

Console.WriteLine("Your point is " + point);

Console.WriteLine("2: Which one of these is an anime series?");
Console.WriteLine("a) Naruto b) ruto c) Nato");
a = "a";
b = "b";
c = "c";
player = Console.ReadLine();

if (player == a)
{
    Console.WriteLine("All right");
   point += 1;
}
else if (player == b)
{
    Console.WriteLine("Bad");
    point -= 1;

}
else if (player == c)
{
    Console.WriteLine("Bad");
      point -= 1;
}
Console.WriteLine("Your point is " + point);
Console.WriteLine("3: Which one of these is a video game");
Console.WriteLine("a) Youtube b) Minecraft c) NetFlix");
a = "a";
b = "b";
c = "c";
player = Console.ReadLine();

if (player == a)
{
    Console.WriteLine("Bad");
    point -= 1;
}
else if (player == b)
{
    Console.WriteLine("All right");
     point += 1;
}
else if (player == c)
{
    Console.WriteLine("Bad");
      point -= 1;
}

Console.WriteLine("Your total is " + point);
int total = point;
if (total <= 1)
{
    Console.WriteLine("Your super bad");
}
Console.ReadLine();

