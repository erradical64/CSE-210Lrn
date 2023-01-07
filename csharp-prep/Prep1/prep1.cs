using System;

class Prep1
{
    public void main(){
        Console.Write("What's your favorite color?: ");
        string color = Console.ReadLine();
        Console.Write("Select a number for x: ");
        string xNumber = Console.ReadLine();
        int x = int.Parse(xNumber);

        Console.Write("Select a number for y: ");
        string yNumber = Console.ReadLine();
        int y = int.Parse(xNumber);
        Console.Write("Select a number for z: ");
        string zNumber = Console.ReadLine();
        int z = int.Parse(xNumber);
        string dueTo = x.ToString();

        
        if (x > y)
        {
            Console.WriteLine($"{x} is greater than {y}.");
            if (x > z)
            {
                Console.WriteLine($"{x} is greater than both {y} and {z}.");
            }
        }
        else if (x == y)
        {
            Console.WriteLine("x is equal to y, with them being both " + dueTo + ".");
            if (x == z)
            {
                Console.WriteLine("x is also equal to z");
            }
        }
        else
        {
            Console.WriteLine($"{x} is less than than {y}.");
            if (x < z)
            {
                Console.WriteLine($"{x} is less than both {y} and {z}.");
            }
        }
        Console.Write("What's your first name?: ");
        string firstName = Console.ReadLine();
        Console.Write("What's your last name?: ");
        string lastName = Console.ReadLine();
        if (firstName == "John" && lastName == "Leguizamo" || firstName == "Bruno" && lastName == "Madrigal")
        {
            Console.WriteLine("Apparently Luigi also.");
        }
        if (x > y){
            Console.WriteLine($"{x} is greater than {y}");
        }
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at the school {school}");
    }
}
