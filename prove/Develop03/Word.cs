using System;
using System.Collections.Generic;

class Word
{    
    //private string _underscore = "_";
    private string _filePath = "scripture.txt";
    
    private List<string> way = new List<string>();
    
    public string pathHere()
    {
        return _filePath;
    }

    public void DisplayOne(string line)
    {
        Console.WriteLine(line);
    }

    public void SortIntoLists(string sentence)
    {
        Scripture scrip = new Scripture();
        string[] sep = sentence.Split(' ');
        scrip.HideScripture(sep);
        
    }
    public void SortIntoListsTwo(string sentence)
    {
        Scripture scrip = new Scripture();
        string[] sep = sentence.Split(' ');
        scrip.HideScriptures(sep);
        
    }
}