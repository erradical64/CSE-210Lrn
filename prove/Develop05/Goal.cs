using System;

public abstract class Goal
{

    protected string _goal;
    protected string _goalDescription;
    protected int _score;

    public Goal()
    {
        _goal = "";
        _goalDescription = "";
        _score = 0;
    }

    public Goal(string goal, string description, int score)
    {
        _goal = goal;
        _score = score;
        _goalDescription = description;
    }
    public abstract void SaveToFile(List<string> Update);

    public virtual void Addition(List<string> scoreAdd)
    {
        string fix = new string("");
        
        foreach(string score in scoreAdd)
        {
            Console.WriteLine(score);
            fix = $"{int.Parse(score) + _score}";
        }
        scoreAdd.Clear();
        scoreAdd.Add(fix);
        Console.WriteLine($"You received {_score} points!");
    }
    public void DisplayForRecordEvent(int indexed)
    {
        Console.WriteLine($"{indexed}. {_goal}");
    }

    public abstract void DisplayListed();
    

    public virtual void RecordEvent(List<string> scoreAdd)
    {
        
    }

    

    public abstract bool IsComplete();
  



}