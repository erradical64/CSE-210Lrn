using System;

public class Wyvern : Enemy
{
    public Wyvern(string name, string desc, int hp, int damage1, int damage2):base(name, desc, hp, damage1, damage2)
    {
        _name = "wyvern";
        _description = "A fiery, horned winged serpent with the talons of a falcon and a venomous barb on the tip of its tail. As with most dragons, the wyvern also packs a terrible breath will torch you and also cause serious harm with their claws.";
        _healthPower = hp;
        _damage1 = damage1;
        _damage2 = damage2;
    }

    public override void CharacterIllustration()
    {
        Console.WriteLine("             _\n    /|      |______________\n   / |___   /|\\        /\n  //◯___/  / | \\      /  ");
        Console.WriteLine(" /  /\\ \\  /  |  \\    /  /\\");
        Console.WriteLine("/._/ / / //\\ | /\\\\  /  /  \\      /\\");
        Console.WriteLine("    /  \\//  \\|/  \\\\/  / /\\ \\    //\\\\"); 
        Console.WriteLine("    \\__ \\____________/ /  \\ \\  //  V");
        Console.WriteLine("     \\  |        _____/    \\ \\//");
        Console.WriteLine("      \\/________/           \\_/");
        Console.WriteLine("      /    \\");
        Console.WriteLine("  ___/__ ___\\__");
    }


}