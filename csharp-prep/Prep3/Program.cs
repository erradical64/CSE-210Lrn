using System;

class Program
{
    static void Main(string[] args)
    {
        string inputOne = "yes";
        string inputTwo = "yes";
        while (inputOne == "yes")
        {
            Console.WriteLine("for while loop example");
            Console.Write("Want to continue?: ");
            inputOne = Console.ReadLine();
        }
        do
        {
            Console.WriteLine("for do-while loop example");
            Console.Write("Want to continue?: ");
            inputTwo = Console.ReadLine();
        } while (inputTwo == "yes");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("for loop example #1");
            Console.WriteLine(i);
        }
        Console.WriteLine("for loop example #2");
        for (int i = 2; i <= 20; i = i + 2)
        {
            
            Console.WriteLine(i);
        }
        Console.WriteLine("foreach loop example");
        string[] colors = {"red", "blue", "yellow", "green", "orange", "purple"};
        foreach (string color in colors)
        {
            
            Console.WriteLine(color);
        }
        Random randomGenerator = new Random();
        int rNumber = randomGenerator.Next(1, 100);
        int guess = -1;
        int guesses = 0;
        Console.WriteLine("Welcome to the number guessing game...");
        string goAgain = "yes";
        while (goAgain == "yes")
        {
            while (guess != rNumber)
            {
                Console.Write("Input your answer here: ");
                guess = int.Parse(Console.ReadLine());
                if (rNumber > guess)
                {
                    Console.WriteLine("Higher");
                    guesses += 1;
                }
                else if (rNumber < guess)
                {
                    Console.WriteLine("Lower");
                    guesses += 1;
                }
                else
                {
                    Console.WriteLine("Congrats, you win!");
                    if (guesses == 1)
                    {
                        Console.WriteLine("You guessed once.");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed {guesses} times.");
                    }
                    Console.Write("Want to continue?: ");
                    goAgain = Console.ReadLine();
                }
                
                
            }
        }


    }
}