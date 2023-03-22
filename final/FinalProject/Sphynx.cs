using System;

public class Sphynx : Enemy
{
    private List<string> _questions;
    private List<string> _answers;

    public Sphynx(string name, List<string> questions, List<string> answers):base(name)
    {
        _name = "sphynx";
        _questions = questions;
        _answers = answers;


    }
    public override void Attack()
    {
        Console.WriteLine("Test");
    }
    public void Quiz()
    {
        _questions.Add("Q1");
        _answers.Add("A1");
    }


}