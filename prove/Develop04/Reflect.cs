using System;

class Reflect: Activity
{
    private string _enter;
    private List<string> _prompts;
    private int _randomNumber;

    
    
    public Reflect(int duration, string name, string description, List<string> prompts, List<string> messages):base(duration, name, description)
    {
        _prompts = prompts;
        _messages = messages;
    }

    public void ReflectOnThisPls()
    {
        BeginningTheActivity();
        ThePrompts();
        Random random = new Random();
        _randomNumber = random.Next(_prompts.Count);
        LoadingAnim(5);
        Console.WriteLine($"--- {_prompts[_randomNumber]} ---");
        _enter = "none";
        while (_enter != "")
        {
            Console.Write("When you have something in mind, press \"enter\" on your keyboard to continue");
            _enter = Console.ReadLine();
        }
        TheMiniPrompts();
        
        Console.Write("");
        foreach (string _mini in _messages)
        {
            Console.Write(_mini);
            CountDownAnim(_duration);
        }
        _duration *= _messages.Count;
        LoadingAnim(5);
        YouHaveCompleted();  
        
    }
    public void ThePrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }

    public void TheMiniPrompts()
    {
        _messages.Add("Why was this experience meaningful to you?" );
        _messages.Add("Have you ever done anything like this before? ");
        _messages.Add("How did you get started?");
        _messages.Add("How did you feel when it was complete?");
        _messages.Add("What made this time different than other times when you were not as successful? ");
        _messages.Add("What is your favorite thing about this experience? ");
        _messages.Add("What could you learn from this experience that applies to other situations? ");
        _messages.Add("What did you learn about yourself through this experience? ");
        _messages.Add("How can you keep this experience in mind in the future? ");
    }
   
}