using System;

class Eternal : Goal
{
    

    public Eternal(string goal, int score, string description):base(goal, description, score){}
    public override void RecordEvent(List<string> scoreAdd)
    {
        if(!IsComplete())
        {
            Addition(scoreAdd);
        }
    }

    public override void SaveToFile(List<string> Update)
    {
        Update.Add($"E:{_goal},{_goalDescription},{_score}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void DisplayListed()
    {

        Console.WriteLine($"[ ] {_goal}:\n - {_goalDescription}.");
    }

    public void DebugLogging()
    {
        
        
    }
}