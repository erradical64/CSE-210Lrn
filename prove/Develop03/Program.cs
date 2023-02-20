using System;
using System.Collections.Generic;

class Program
{
   //This code can also allow the user add desired scriptures via text file.

    static void Main(string[] args)
    {
        Scripture scriptureThis = new Scripture();
        string loop = "";
        string insert = "";
        string refChoose = "";
        do 
        {
            Word aWord = new Word();
            Reference aReference = new Reference();
            string filePath = aWord.pathHere();

            Console.Write("Press Enter to Continue or type 'quit' to stop program: ");
            loop = Console.ReadLine();
            if(loop == "")
            {
                Console.WriteLine("1. Insert a new scripture?");
                Console.WriteLine("2. Guess a scripture?");
                Console.WriteLine("3. Forget about it?");
                Console.WriteLine("4. Clear Console?");

                Console.Write("(Type '1', '2', '3' or '4'): ");
                insert = Console.ReadLine();
                if(insert == "1")
                {
                    scriptureThis.AddNewScriptures();
                    
                }
                else if(insert == "2")
                {

                    //string anotherLoop = "";
                    aReference.getScriptures();
                    refChoose = "";
                    Console.Write("Do one verse or another? (1 or 2): ");
                    refChoose = Console.ReadLine();
                    if (refChoose == "1")
                    {
                        aReference.DisplaySingleReference();
                    }
                    else
                    {
                        aReference.DisplayMultipleReferences();
                    }

                }
                else if(insert == "4")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Okay, wanna quit this program?");
                }
            }
        }
        while(loop != "quit");
    }
    public void InsertOrDont()
    {
        
    }

}