using System;

public class Sphynx : Enemy
{
    public Sphynx(string name):base(name)
    {
        _name = "sphynx";
    }
    public override void Attack()
    {
        Console.WriteLine("Test");
    }
    public void Quiz()
    {

    }


}