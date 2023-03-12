using System;

public class SaveAndLoad
{
    private string _textFile;
    private string[] _lines;

    private int _totalScore;

    public SaveAndLoad()
    {
        _textFile = "goals.txt";
        _lines = System.IO.File.ReadAllLines(_textFile);
        _totalScore = int.Parse(_lines[0]);
    }

    public void GetTheScore(List<string> score)
    {
        score.Add($"{_totalScore}"); 
    }

    public void DisplayScore(List<string> score)
    {
        foreach (string s in score)
        {
            Console.WriteLine($" \nYou currently have {s} points.\n");
        }
    }

    public void GetTheGoals(List<Goal> GoalsHere)
    {

        for (int i = 1; i < _lines.Count(); i++)
        {
            string[] sort = _lines[i].Split(":");
            if (sort[0] == "S")
            {
                string[] commas = sort[1].Split(",");

                Simple s = new Simple(commas[0], int.Parse(commas[2]), commas[1], bool.Parse(commas[3]));
                GoalsHere.Add(s);
            }
            else if (sort[0] == "E")
            {
                string[] commas = sort[1].Split(",");

                Eternal e = new Eternal(commas[0], int.Parse(commas[2]), commas[1]);
                GoalsHere.Add(e);
            }
            else if(sort[0] == "C")
            {
                string[] commas = sort[1].Split(",");

                Checklist c = new Checklist(commas[0], int.Parse(commas[2]), commas[1], int.Parse(commas[3]), int.Parse(commas[4]), int.Parse(commas[5]));
                GoalsHere.Add(c);
            }
        }
    }    
    public void CreateNewGoal(List<Goal> GoalsHere)
    {
        int aSECTypeNo = new int();
        int newScore = new int();
        
        string newGoal = new string("");
        string goalDesc = new string("");

        Console.WriteLine("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Select a choice from the menu: ");
        aSECTypeNo = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of your goal: ");
        newGoal = Console.ReadLine();
        Console.Write("Enter a brief description of your goal in one sentence without commas: ");
        goalDesc = Console.ReadLine();
        Console.Write("Enter the points that your goal is worth: ");
        newScore = int.Parse(Console.ReadLine());

        if (aSECTypeNo == 1)
        {
            string newGoalDetails = new string($"S:{newGoal},{goalDesc},{newScore},False");

            AddToFile(newGoalDetails, GoalsHere);   
        }
        else if (aSECTypeNo == 2)
        {
            string newGoalDetails = new string($"E:{newGoal},{goalDesc},{newScore}");

            AddToFile(newGoalDetails, GoalsHere);
        }
        else
        {
            int timesToGo = new int();
            int bonusTen = new int();

            Console.Write("Enter the times you want to check off: ");
            timesToGo = int.Parse(Console.ReadLine());

            Console.Write("What bonus would like to achieve?: ");
            bonusTen = int.Parse(Console.ReadLine());
            
            string newGoalDetails = new string($"C:{newGoal},{goalDesc},{newScore},{bonusTen},{timesToGo},0");
            AddToFile(newGoalDetails, GoalsHere);
        }
    }

    public void PrintAList(List<Goal> GoalsHere)
    {
        foreach (Goal GoalsToList in GoalsHere)
        {
            GoalsToList.DisplayListed();
        }
    }

    public void SaveYourProgress(List<Goal> GoalsHere, List<string> NewList, List<string> score)
    {
        using (StreamWriter outputFile = new StreamWriter(_textFile))
        {
            foreach (Goal goals in GoalsHere)
            {
                goals.SaveToFile(NewList);
            }
            
            foreach (string s in score)
            {
                outputFile.WriteLine(s);
            }
            
            foreach (string Ws in NewList)
            {
                outputFile.WriteLine(Ws);
            }
        } 
    }

    public void LoadOfLoading(List<Goal> GoalsHere)
    {
        GoalsHere.Clear();
        GetTheGoals(GoalsHere);
    }

    public void AddToFile(string textLine, List<Goal> GoalsHere)
    {
        using (StreamWriter outputFile = new StreamWriter(_textFile))
        {
            foreach (string line in _lines)
            {
                outputFile.WriteLine(line);
            }
            outputFile.WriteLine(textLine);
        }
        _lines = System.IO.File.ReadAllLines(_textFile);
        GoalsHere.Clear();
        GetTheGoals(GoalsHere);
    }
    public void RecordProgress(List<Goal> GoalsHere, List<string> score)
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < GoalsHere.Count(); i++)
        {
            int numeral = i + 1;
            GoalsHere[i].DisplayForRecordEvent(numeral);
        }
        Console.Write("\nWhat did you accomplish?: ");
        int choose = int.Parse(Console.ReadLine()) - 1;

        GoalsHere[choose].RecordEvent(score);
        

    }

    public void Logo()
    {
        Console.WriteLine();
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
        Console.WriteLine("| ___                           |");
        Console.WriteLine(" (   )imple                     ");
        Console.WriteLine("| \\_   _______                  |");
        Console.WriteLine("    \\  \\   ternal               ");
        Console.WriteLine("|(___). \\___      _____         |");
        Console.WriteLine("        /        /    heckList  ");
        Console.WriteLine("|      /______. /               |");
        Console.WriteLine("                \\                ");
        Console.WriteLine("|                \\_____.  GOALS!|");
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
    }

    public void DeleteAGoal(List<Goal> GoalsHere)
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < GoalsHere.Count(); i++)
        {
            int numeral = i + 1;
            GoalsHere[i].DisplayForRecordEvent(numeral);
        }
        Console.Write("\nWhich One would you like to delete?: ");
        int choose = int.Parse(Console.ReadLine()) - 1;
        Console.Write($"You sure you want to delete number {choose + 1}? Input 'yes' to confirm: ");
        string confirm = Console.ReadLine();
        if (confirm.ToLower() == "yes")
        {
            GoalsHere.RemoveAt(choose);
        }
    }
}