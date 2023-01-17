using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        List<string> words;
        words = new List<string>();
        words.Add("schadenfraude");
        words.Add("bear");
        words.Add("eagle");
        words.Add("room");
        words.Add("job");
        foreach (string word in words)
        {   
            Console.WriteLine(word);
            
                
        }
        for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine($"{i} - {words[i]}");
            }
        
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"words: {words.Count}");
        Console.WriteLine($"numbers: {numbers.Count}");
        List<int> nums = new List<int>();
        int userNum = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            userNum = int.Parse(response);

            if (userNum != 0)
            {
                nums.Add(userNum);
            }
        }
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / nums.Count;
        Console.WriteLine($"The average is {average}");

        int max = nums[0];
        foreach (int num in nums)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is {max}");
        
    }
}