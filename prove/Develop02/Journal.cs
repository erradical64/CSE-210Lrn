using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Journal
{

    public void getFile()
    {
        string filePath = "journal.txt";
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath).ToList();
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    public void printIntoFile(string add)
    {
        string filePath = "journal.txt";
        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath).ToList();
        lines.Add(add);
        File.WriteAllLines(filePath, lines);
        Console.ReadLine();
        Console.WriteLine("Your prompt was printed into a journal.");
        
    }
}