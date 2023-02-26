using System;

class Listing: Activity
{
    //private string _messages;
    private List<string> _prompts;
    private string _enter;
    public string _answer;

    private int _randomNumber;
    private int _answers;

   


    public Listing()
    {
        _enter = "none";
        _randomNumber = 0;
        _answers = 0;
        _answer = "";
    }
    
    public Listing(int duration, string name, string description, List<string> prompts):base(duration, name, description)
    {
        _prompts = prompts;
    }

    public void ListThesePls()
    {
        BeginningTheActivity();
        ThePrompts();
        Random _random = new Random();
        _randomNumber = _random.Next(_prompts.Count);

        LoadingAnim(5);
        Console.WriteLine($"--- {_prompts[_randomNumber]} ---");
        //int answers = 0;
        while (_enter != "")
        {
            Console.Write("When you have something in mind, press \"enter\" on your keyboard to continue");
            _enter = Console.ReadLine();
        }

        LoadingAnim(5);
        SetTimer();
        
        while (_currentTime < _endingTime)
        {
            _currentTime = DateTime.Now;
            Console.Write(">> ");

            _answer = Console.ReadLine();
            _answers += 1;
        }
        if (_answers > 1)
        {
            Console.WriteLine($"You have listed {_answers} items total!");
        }
        else
        {
            Console.WriteLine($"You have listed {_answers} item total!");
        }
        
        LoadingAnim(5);
        YouHaveCompleted();
        
    }

    public void ThePrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    
   
}