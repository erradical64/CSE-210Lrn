using System;

class Checklist : Goal
{
    private int _total;
    private int _times;
    private int _bonus;


    public Checklist(string goal, int score, string description, int bonus, int total, int times):base(goal, description, score)
    {
        _bonus = bonus;
        _times = times;
        _total = total;
    }

    public override void SaveToFile(List<string> Update)
    {
        Update.Add($"C:{_goal},{_goalDescription},{_score},{_bonus},{_total},{_times}");
    }

    public override void Addition(List<String> scoreAdd)
    {
        string fix = new string("");
        
        if (_times == 10)
        {
            foreach(string score in scoreAdd)
            {
                Console.WriteLine(score);
                fix = $"{int.Parse(score) + _score + _bonus}";
            }
            scoreAdd.Clear();
            scoreAdd.Add(fix);
            Console.WriteLine($"With a bonus of {_bonus}, you received {_score} points!");
        }
        else
        {
            foreach(string score in scoreAdd)
            {
                Console.WriteLine(score);
                fix = $"{int.Parse(score) + _score}";
            }
            scoreAdd.Clear();
            scoreAdd.Add(fix);
            Console.WriteLine($"You received {_score} points!");
        }
    }

    public override void DisplayListed()
    {
        if (_total > _times)
        {
            Console.WriteLine($"[ ] {_goal}:\n - {_goalDescription}. --- Currently Completed: {_times}/{_total}");
        }
        else
        {
            Console.WriteLine($"[✓] {_goal}:\n - {_goalDescription}.");
        }
    }

    public override void RecordEvent(List<string> scoreAdd)
    {
        if(!IsComplete())
        {
            Addition(scoreAdd);
            _times = _times + 1;
            Console.WriteLine($"You have {_total - _times} left");
        }
        else
        {
            Console.WriteLine("You already completed this goal");
        }
    }
    public override bool IsComplete()
    {
        if (_total == _times)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}