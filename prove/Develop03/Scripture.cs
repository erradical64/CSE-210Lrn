using System;
using System.Collections.Generic;

class Scripture
{
    //public Word _sentences;
    //private string _sentence = new string(char);

    //private string useSentence(){
        //return _sentence;
    //}
    
   


    //private Reference _references;
    //private string _text;

    /*public Scripture(string scriptures, string texts)
    {
        _scripture = scriptures;
        _text = texts;
    }*/
    
    public void DisplayScriptures(string location, string sentence)
    {
        Word pizzaz = new Word();
        
        Console.Clear();
        Console.WriteLine(location);
        Console.WriteLine(sentence);

        Console.Write("Make the words disappear? (press the enter key to confirm, type 'quit' to exit): ");
        string scriptureLoop = Console.ReadLine();
        int increase = 1;
        do{
            Console.Clear();
            
            if (increase > 1)
            {
                Console.WriteLine(location);
                pizzaz.SortIntoListsTwo(sentence);
            }
            else
            {
                Console.WriteLine(location);
                pizzaz.SortIntoLists(sentence);
            }
            increase += 1;
            Console.Write("Go again? (press the enter key to confirm, type 'quit' to exit): ");
            scriptureLoop = Console.ReadLine();
        }while (scriptureLoop != "quit");
        
    }
    

    public void HideScripture(string[] sep)
    {
        int notFullLength = (sep.Length + 1);
        
        var random = new Random();
        int r = random.Next(1, notFullLength);
        sep[r] = "______";
        string thisOne = sep.Aggregate((a, b) => a + " " + b);

        
        Console.WriteLine(thisOne);
    }
    public void HideScriptures(string[] sep)
    {
        int notFullLength = (sep.Length + 1);
        
        var random = new Random();
        int r = random.Next(1, notFullLength);
        sep[r] = "______";
        string thisOne = sep.Aggregate((a, b) => a + " " + b);

        int r2 = random.Next(2, notFullLength);
        sep[r2] = "______";
        thisOne  = sep.Aggregate((a, b) => a + " " + b);
        int r3 = random.Next(3, notFullLength);
        sep[r3] = "______";
        thisOne = sep.Aggregate((a, b) => a + " " + b);

        
        Console.WriteLine(thisOne);
    }
    
    public void AddNewScriptures()
    {
        Word aWord = new Word();
        string filePath = aWord.pathHere();
        
        Console.Write("Enter Book Name: ");
        string book = Console.ReadLine();
        Console.Write("Enter Chapter Number: ");
        string chapter = Console.ReadLine();
        Console.Write("Enter Verse Number: ");
        string verseNo = Console.ReadLine();
        Console.Write("Enter Verse Sentence: ");
        string verseItself = Console.ReadLine();

        string printable = $"{book} + -{chapter}:{verseNo} / {verseItself}";
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath).ToList();
        lines.Add(printable);
        File.WriteAllLines(filePath, lines);
    }
}