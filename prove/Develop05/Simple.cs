using System;

class Simple : Goal
{
    private Boolean _complete;
    
    public Simple(string goal, int score, string description, bool complete):base(goal, description, score)
    {
        _complete = complete;
    }

    public override void SaveToFile(List<string> Update)
    {
        Update.Add($"S:{_goal},{_goalDescription},{_score},{_complete}");
    }
    public override void DisplayListed()
    {
        if (_complete == false)
        {
            Console.WriteLine($"[ ] {_goal}:\n - {_goalDescription}.");
        }
        else
        {
            Console.WriteLine($"[✓] {_goal}:\n - {_goalDescription}.");
        }
    }

    public override void RecordEvent(List<string> scoreAdd)
    {
        if (!IsComplete())
        {
            Addition(scoreAdd);
            _complete = true;
        }
        else
        {
            Console.WriteLine("You already completed this goal");
        }
    }
    public override bool IsComplete()
    {
        if (_complete == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}