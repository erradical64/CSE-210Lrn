using System;
using System.Collections.Generic;

class Reference
{
    //do arrays for book
    //private List<string> _book;
    //private int _chapter;
    //private int _verse;
    //private List<string> Line;
    
    
    
    public void DisplayMultipleReferences()
    {
        Word aWord = new Word();
        string cheese = aWord.pathHere();
        
        Console.WriteLine("Which one would you like to choose?");
        Console.Write("Enter Book Name: ");
        string book = Console.ReadLine();
        Console.Write("Enter Chapter Number: ");
        string chapterNo = Console.ReadLine();
        Console.Write("Enter Verse Numbers (format #-#): ");
        string verseNo = Console.ReadLine();
        string verse1 = verseNo.Substring(0, verseNo.IndexOf("-"));
        string verse2 = verseNo.Substring(verseNo.IndexOf("-") + 1);
        Console.WriteLine($"{verse1} {verse2}");

        List<string> lines = new List<string>();
        List<string> bookTest = new List<string>();
        List<string> verseTest = new List<string>();
        List<string> chapterTest = new List<string>();
        List<string> sentenceTest = new List<string>();

        lines = File.ReadAllLines(cheese).ToList();
        foreach (string line in lines)
        {
            string location = line.Substring(0, line.IndexOf(" / "));
            string booked = location.Substring(0, location.IndexOf(" + "));
            string versed = location.Substring(location.IndexOf("-") + 1);
            string chapter = versed.Substring(0, versed.IndexOf(":"));
            string chapterVerse = versed.Substring(versed.IndexOf(":") + 1);
            string lined = line.Substring(line.IndexOf(" / ") + 2);
            
            bookTest.Add(booked);
            chapterTest.Add(chapter);
            verseTest.Add(chapterVerse);
            sentenceTest.Add(lined);
        }
        int bookIndex = bookTest.IndexOf(book);
        int chapterIndex = chapterTest.IndexOf(chapterNo);
        int verse1Index = verseTest.IndexOf(verse1);
        int verse2Index = verseTest.IndexOf(verse2);
        int sentenceIndex = sentenceTest.IndexOf(verseNo);
        

        Console.WriteLine($"{bookIndex} + {chapterIndex} + {verse1Index} : ");
        Console.WriteLine($"{bookTest[bookIndex]} + {chapterTest[chapterIndex]} + {verseTest[verse1Index]} : {sentenceTest[verse1Index]}");
        string scriptureLocation = $"{bookTest[bookIndex]} {chapterTest[chapterIndex]}:{verseTest[verse1Index]}-{verseTest[verse2Index]}";
        string scriptureSentence = $"{sentenceTest[verse1Index]} {sentenceTest[verse2Index]}";
        Console.WriteLine(scriptureSentence);

        Scripture s = new Scripture();
        s.DisplayScriptures(scriptureLocation, scriptureSentence);

    }
    public void DisplaySingleReference()
    {
        Word aWord = new Word();
        string cheese = aWord.pathHere();

        Console.WriteLine("Which one would you like to choose?");
        Console.Write("Enter Book Name: ");
        string book = Console.ReadLine();
        Console.Write("Enter Chapter Name: ");
        string chapterNo = Console.ReadLine();
        Console.Write("Enter Verse Number: ");
        string verseNo = Console.ReadLine();
        
        List<string> lines = new List<string>();
        List<string> bookTest = new List<string>();
        List<string> verseTest = new List<string>();
        List<string> chapterTest = new List<string>();
        List<string> sentenceTest = new List<string>();
        

        lines = File.ReadAllLines(cheese).ToList();
        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            string location = line.Substring(0, line.IndexOf(" / "));
            string booked = location.Substring(0, location.IndexOf(" + "));
            string versed = location.Substring(location.IndexOf("-") + 1);
            string chapter = versed.Substring(0, versed.IndexOf(":"));
            string chapterVerse = versed.Substring(versed.IndexOf(":") + 1);
            string lined = line.Substring(line.IndexOf(" / ") + 2);
            
            //chapterAndVerse.Add(versed);
            bookTest.Add(booked);
            chapterTest.Add(chapter);
            verseTest.Add(chapterVerse);
            sentenceTest.Add(lined);

        }
        int bookIndex = bookTest.IndexOf(book);
        int chapterIndex = chapterTest.IndexOf(chapterNo);
        int verseIndex = verseTest.IndexOf(verseNo);
        int sentenceIndex = sentenceTest.IndexOf(verseNo);
        

        Console.WriteLine($"{bookIndex} + {chapterIndex} + {verseIndex} : ");
        Console.WriteLine($"{bookTest[bookIndex]} + {chapterTest[chapterIndex]} + {verseTest[verseIndex]} : {sentenceTest[verseIndex]}");
        string scriptureLocation = $"{bookTest[bookIndex]} {chapterTest[chapterIndex]}:{verseTest[verseIndex]}";
        string scriptureSentence = sentenceTest[verseIndex];
        Scripture s = new Scripture();
        s.DisplayScriptures(scriptureLocation, scriptureSentence);

    }
    public void getScriptures()
    {
        Word aWord = new Word();
        string pathTobeTaken = aWord.pathHere();

        List<string> lines = new List<string>();
        List<string> bookTest = new List<string>();
        List<int> verseTest = new List<int>();
        List<int> chapterTest = new List<int>();
        List<string> chapterAndVerse = new List<string>();

        lines = File.ReadAllLines(pathTobeTaken).ToList();
        foreach (string line in lines)
        {
            string location = line.Substring(0, line.IndexOf(" / "));
            string booked = location.Substring(0, location.IndexOf(" + "));
            string versed = location.Substring(location.IndexOf("-") + 1);
            string chapter = versed.Substring(0, versed.IndexOf(":"));
            string chapterVerse = versed.Substring(versed.IndexOf(":") + 1);
            chapterAndVerse.Add(versed);
            string lined = line.Substring(line.IndexOf(" / ") + 2);
            Console.WriteLine($"{booked} {chapter}:{chapterVerse} {lined}");
            chapterTest.Add(int.Parse(chapter));
        }
        

    }
    

    
}