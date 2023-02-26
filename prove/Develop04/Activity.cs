using System;

class Activity
{
    protected int _duration;

    protected string _name;
    protected string _description;

    protected DateTime _startingTime;
    protected DateTime _currentTime;
    protected DateTime _endingTime;

    protected List<string> _messages;
    
    public Activity()
    {
        _duration = 0;
        _name = "null";
        _description = "N/A";
    }

    public Activity(int duration, string name, string description)
    {
        _duration = duration;
        _name = name;
        _description = description;
    }
    public void BeginningTheActivity()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Set the duration time in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        Console.Write("");
        return;
    }

    public void DebuggingPurposesDontAsk()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Set the duration time in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Write("Loading, Do not close the program! ");
        LoadingAnim(_duration);
    }
    //string name, int seconds
    public void YouHaveCompleted()
    {
        Console.WriteLine("Well Done!");
        LoadingAnim(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        LoadingAnim(5);
    }
    public void LoadingAnim(int seconds)
    {
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(seconds);
        List<string> _spinner = new List<string>();
        _spinner.Add("|"); //1
        _spinner.Add("/"); //2
        _spinner.Add("-"); //3
        _spinner.Add("\\"); //4
        _spinner.Add("|"); //5
        _spinner.Add("/"); //6
        _spinner.Add("-"); //7
        _spinner.Add("\\"); //8

        int i = 0;
        
        while (DateTime.Now < _endTime)
        {
            string s = _spinner[i];
            Console.Write(s);
            Thread.Sleep(100); //1000
            Console.Write("\b \b");
            
            i++;
            if(i >= _spinner.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine(); 
        
    }
    public void CountDownAnim(int seconds)
    {
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(seconds);
        
        
        
        while (DateTime.Now < _endTime)
        {
            
            Console.Write($" {seconds}");

            Thread.Sleep(1000); 
            
            if (seconds > 9)
            {
                Console.Write("\b \b");
                Console.Write("\b \b");
                Console.Write("\b \b");
            }
            else
            {
                Console.Write("\b \b");
                Console.Write("\b \b");
            }
            seconds -= 1;
            
            
        }
        Console.WriteLine(); 
        
    }

    public void SetTimer()
    {
        _startingTime = DateTime.Now;
        _currentTime = _startingTime.AddSeconds(0);
        _endingTime = _startingTime.AddSeconds(_duration);
    }





}