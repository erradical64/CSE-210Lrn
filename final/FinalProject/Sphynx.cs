using System;

public class Sphynx : Enemy
{
    private List<string> _questions;
    private List<string> _answers;

    public Sphynx(string name, string desc, int hp, List<string> questions, List<string> answers, int damage1, int damage2):base(name, desc, hp, damage1, damage2)
    {
        _name = "sphynx";
        _description = "An enigmatic sight, a lion with the head of a human that loves playing dangerous games of riddles with its victims to determine whether it will attack.";
        _healthPower = hp;
        _questions = questions;
        _answers = answers;
        _damage1 = damage1;
        _damage2 = damage2;
        QuizAdd();

    }

    public override void CharacterIllustration()
    {
        Console.WriteLine("          V\n      V___|___V\n     ////---\\\\\\\\  ");
        Console.WriteLine("    /// ◯\\ /◯ \\\\\\                ");
        Console.WriteLine("   /||\\   △   /||\\                                 ####\n  /||||\\_\\_/_/||||\\                               ###\n  \\||||||| |||||||/                              ####");
        Console.WriteLine("        /   \\  ______________________           //\n       /     \\/                      \\         //\n      /                          _____\\       //");
        Console.WriteLine("      \\         __              /     \\\\_____//\n       \\       /  \\            /      / |____/");
        Console.WriteLine("        \\______\\   \\___________\\     /_/");
        Console.WriteLine("          \\   \\ \\   \\     \\   / \\   /\n           \\  |  \\  |      \\  \\  \\  \\\n        ___/  |__/  |   ___/  |__/  |\n       (_|_|_(_|_|__|  (_|_|_(_|_|__|");
    }
    public override void Attack(Inventory inventory)
    {
        Quiz(inventory);
    }
    public void QuizAdd()
    {
        _questions.Add("What do I have the body of?"); //1
        _answers.Add("lion");

        _questions.Add("What walks on all fours in the morning, two at noon, and three in the evening"); //2
        _answers.Add("man");

        _questions.Add("What is red combined with blue"); //3
        _answers.Add("purple");

        _questions.Add("Which of the following creatures are NOT in this cavern, Wyverns or Basilisks?"); //4
        _answers.Add("basilisks");

        _questions.Add("Which of the following creatures ARE in this cavern, Wyverns or Goblins?"); //5
        _answers.Add("wyverns");

        _questions.Add("What is yellow combined with blue"); //6
        _answers.Add("green");

        _questions.Add("What is the airspeed velocity of an unlaiden swallow?"); //7
        _answers.Add("african or european swallow");

    }
    public void Quiz(Inventory invent)
    {
        Random r = new Random();
        int chosenOne = r.Next(1,(_questions.Count()+1)) - 1;
        Console.WriteLine(_questions[chosenOne]);
        Console.Write("Input your answer here: ");
        string answer = Console.ReadLine();
        if (answer.ToLower() == _answers[chosenOne])
        {
            if(chosenOne == 6)
            {
                Console.WriteLine("I don't know that!");
                _healthPower -= _healthPower;
            }
            else
            {
                Console.WriteLine("Bravo, you got that one correct!");
            }
        }
        else
        {
            invent.UnderAttack(_damage1, _damage2);
        }
    }

    


}