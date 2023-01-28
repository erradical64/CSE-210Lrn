using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
class Program
{

    static void Main(string[] args)
    {
        Prompt APrompt = new Prompt();
        Journal journalLocation = new Journal();
        APrompt.promptPrint();

        Console.Write("Want to print this to a journal?: ");
        string confirmThis = Console.ReadLine();
        Console.WriteLine(APrompt.currentPrompt);
        
        if (confirmThis.ToLower() == "yes")
        {
            journalLocation.printIntoFile(APrompt.currentPrompt);
        }
        else{
            Console.WriteLine("Affirmative");
        }

        Console.Write("Want to print out a journal?: ");
        string journalPrint = Console.ReadLine();
        if (journalPrint.ToLower() == "yes")
        {
            journalLocation.getFile();
        }
        else{
            Console.WriteLine("This program was closed");
        }

    }

   

}