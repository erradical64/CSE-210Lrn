using System;

public class Prompt{
    public Entry anEntry = new Entry();
    public string currentPrompt;
    DateTime today = DateTime.Today;
    
    public void promptPrint(){
        Random r = new Random();
        int result  = r.Next(1, 6);
        Console.WriteLine($"Question No. {result}");
        if (result == 1)
        {
            anEntry.writeNoIchi();
            string PapaJohns = $"{today.ToString("dd/MM/yyyy")} - {anEntry._1Question} - {anEntry._1Entry}";
            currentPrompt = PapaJohns;
            Console.WriteLine(currentPrompt);
        }
        else if (result == 2)
        {
            anEntry.writeNoNi(); 
            string PizzaHut = $"{today.ToString("dd/MM/yyyy")} - {anEntry._2Question} - {anEntry._2Entry}";
            currentPrompt = PizzaHut;
            Console.WriteLine(currentPrompt);
        }
        else if (result == 3)
        {
            anEntry.writeNoSan();
            string Dominos = $"{today.ToString("dd/MM/yyyy")} - {anEntry._3Question} - {anEntry._3Entry}";
            currentPrompt = Dominos;
            Console.WriteLine(currentPrompt);

        }
        else if (result == 4)
        {
            anEntry.writeNoYon();
            string CiCis = $"{today.ToString("dd/MM/yyyy")} - {anEntry._4Question} - {anEntry._4Entry}";
            currentPrompt = CiCis;
            Console.WriteLine(currentPrompt);

        }
        else
        {
            anEntry.writeNoGo();
            string littleCaesers = $"{today.ToString("dd/MM/yyyy")} - {anEntry._5Question} - {anEntry._5Entry}";
            currentPrompt = littleCaesers;
            Console.WriteLine(currentPrompt);

        }

          
    }
    
}