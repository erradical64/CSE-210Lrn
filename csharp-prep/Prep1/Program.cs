using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Written in C#.");
        Console.Write("What's your favorite color?: ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your favorite color is {color}");
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at the school {school}");
        Console.Write("What's your first name?: ");
        string first = Console.ReadLine();
        Console.Write("What's your last name?: ");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}");

    }
}