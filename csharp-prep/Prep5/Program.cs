using System;

class Program
{
    static void Main(string[] args)
    {

        //returnType FunctionName(dataType parameter1, dataType parameter2)
        //{
            // function_body
        //}
        
        Console.Write("Enter name here: ");
        string name = Console.ReadLine();
        void DisplayPersonalMessage(string userName)
        {
            Console.WriteLine($"Hello, {userName}");
        }
        DisplayPersonalMessage(name);
        Console.WriteLine(AddNum(5, 5));
        DisplayWelcome();
        string user = PromptUserName();
        int number = PromptUserNumber();
        int squaredNum = SquareNumber(number);

        DisplayResult(user, number, squaredNum);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello world!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        return num;
        
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static int AddNum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
    static void DisplayResult(string user, int number, int squared)
    {
        Console.WriteLine($"{user}, the square of your number ('Which is {number}') is {squared}");
    }
    
    
}