using System;

public class Entry{
    public string  _1Question = "How was your day today?";
    public string _1Entry;

    public string  _2Question = "What was your biggest achievement today?";
    public string _2Entry;

    public string _3Entry;
    public string  _3Question = "What do you plan on doing later today?";

    public string _4Entry;
    public string  _4Question = "What did you do yesterday?";

    public string _5Entry;
    public string  _5Question = "What's you plan for tomorrow?";


    public void writeNoIchi()
    {
        Console.WriteLine(_1Question);
        Console.Write("Input answer here: ");
        _1Entry = Console.ReadLine();
    }
    public void writeNoNi()
    {
        Console.WriteLine(_2Question);
        Console.Write("Input answer here: ");
        _2Entry = Console.ReadLine();
    }
    public void writeNoSan()
    {
        Console.WriteLine(_3Question);
        Console.Write("Input answer here: ");
        _3Entry = Console.ReadLine();
    }
    public void writeNoYon()
    {
        Console.WriteLine(_4Question);
        Console.Write("Input answer here: ");
        _4Entry = Console.ReadLine();
    }
    public void writeNoGo()
    {
        Console.WriteLine(_5Question);
        Console.Write("Input answer here: ");
        _5Entry = Console.ReadLine();
    }
    
}