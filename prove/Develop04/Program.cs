using System;


class Program
{

    static void Main(string[] args)
    {
        Boolean loop = true;
        while (loop != false)
        {
            string select = "";
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Guessing Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu's list above: ");
            
            select = Console.ReadLine();
            if(select == "0")
            {
                Activity activity = new Activity(10, "Debugging purposes", "This is for debugging purposes, don't ask why this is here!");
                activity.DebuggingPurposesDontAsk();
            }
            else if(select == "1")
            {
                List<string> _theMessages = new List<string>{};
                Breath breath = new Breath(10, "Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", _theMessages);
                breath.StartBreathingPls();
            }
            else if (select == "2")
            {
                List<string> _thePrompts = new List<string>{};
                List<string> _theMessages = new List<string>{};
                Reflect reflect = new Reflect(10, "Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", _thePrompts, _theMessages);
                reflect.ReflectOnThisPls();

            }
            else if (select == "3")
            {
                List<string> _thePrompts = new List<string>{};
                Listing list = new Listing(10, "Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", _thePrompts);
                list.ListThesePls();
            }
            else if (select == "4")
            {
                List<string> _theImages = new List<string>{};
                List<string> _imagesNames = new List<string>{};
                Visual visual = new Visual(10, "Guessing Activity","This activity will present you with printed lines of text representing a image, and you will have to guess the images until the time runs out.", _theImages, _imagesNames);
                visual.VisualizeThisPls();
            }
            else if (select == "9")
            {
                Activity activity = new Activity(10, "Activity 9", "四と九とどっちのほうが悪いですか？");
                activity.DebuggingPurposesDontAsk();
            }
            else
            {
                loop = false;
            }
        }
        
        

    }
   
}