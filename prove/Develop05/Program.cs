using System;

class Program
{
    //Will allow user to delete a goal if desired.
    static void Main(string[] args)
    {
       
        List <String> score = new List <string>();
        
        List<Goal> goals = new List<Goal>();
        SaveAndLoad SL = new SaveAndLoad();
        SL.GetTheScore(score);

        SL.GetTheGoals(goals);
        int loop = new int();
        loop = 0;

        SL.Logo();
    
        while(loop != 7)
        {
            SL.DisplayScore(score);

            Console.WriteLine("Menu Options.\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Delete Goal\n7. Quit\n");
            Console.Write("Select a choice from the menu: ");

            loop = int.Parse(Console.ReadLine());

            if(loop == 1)
            {
                SL.CreateNewGoal(goals);
            }
            else if(loop == 2)
            {
                SL.PrintAList(goals);
            }
            else if(loop == 3)
            {
                List<string> stringsToSave = new List<String>();
                SL.SaveYourProgress(goals, stringsToSave, score);
            }
            else if(loop == 4)
            {
                SL.LoadOfLoading(goals);
            }
            else if(loop == 5)
            {
                SL.RecordProgress(goals, score);
                
            }
            else if(loop == 6)
            {
                SL.DeleteAGoal(goals);
            }
        }
    }

    
}