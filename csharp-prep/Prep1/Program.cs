using System;

class Program
{

    
    static void Main(string[] args)
    {
        var addValue = new Add();
        string number = addValue.Privatized();
        Add added = new Add();
        Console.Write("Enter a number: ");
        string publicOne = Console.ReadLine();
        added.AddThis(number, publicOne);
        Console.WriteLine($"The sum is {added.summed}.");

        Console.Write("Enter a number: ");
        string firstA = Console.ReadLine();
        Console.Write("Enter another number: ");
        string secondA = Console.ReadLine();
        Add adder = new Add();
        
        adder.firstNum = int.Parse(firstA);
        
        adder.secondNum = int.Parse(secondA);
        
        adder.Addition();
        Console.WriteLine($"Number = {adder.sum}");


        
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