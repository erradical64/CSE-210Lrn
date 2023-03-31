using System;

public class Item
{
    private string _name;
    private string _description;
    
    private int _healthP;
    private int _magicP;

    public int magXtra()
    {
        return _magicP;
    }

    public int heartXtra()
    {
        return _healthP;
    }


    public Item(string name, string desc, int hp, int mp)
    {
        _name = name;
        _description = desc;
        _healthP = hp;
        _magicP = mp;
    }
    
    public void YouGot()
    {
        Console.WriteLine($"\nYou got a {_name}! it is worth {_healthP}HP and {_magicP}MP.");
    }

    public void ReadDescription()
    {
        Console.WriteLine($"\n{_description}");
    }

    public void GetName(int numeralList)
    {
        Console.WriteLine($"{numeralList}. {_description}");
    }

    public void ApplyMagicAndMagic()
    {
       Console.WriteLine($"You got {_healthP}HP and {_magicP}MP from this {_name}!");
    }
}