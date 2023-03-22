using System;

public class Item
{
    private string _name;
    private string _description;
    private int _healthP;
    private int _magicP;

    public Item()
    {
        _name = "N/A";
        _description = "N/A";
        _healthP = 0;
        _healthP = 0;
    }

    public Item(string name, string desc, int hp, int mp)
    {
        _name = name;
        _description = desc;
        _healthP = hp;
        _magicP = mp;
    }
    
    public void ReadDescription()
    {
        Console.WriteLine(_description);
    }
}