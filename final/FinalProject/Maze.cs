using System;

public class Maze
{
    public bool test = true;
    public List<Room> _rooms;
    public int _score;

    public bool InBattle;

    public int _forward;
    public int _left;
    public int _right;
    public int _health;

    public Maze()
    {

    }
    public void NavigateRooms()
    {
        int quardX = 1;
        int quardY = 1;
        RoomSet();

        //_rooms.Append(room1);


        while (test)
        {
           Console.Write("Left, Right or Forward?: ");
           string inputter = Console.ReadLine();

           if (inputter.ToUpper() == "RIGHT" && quardX < 9)
           {
                quardX += 1; 
           }
           else if(inputter.ToUpper() == "FORWARD" && quardY < 9)
           {
                quardY += 1; 
           }
           else if(inputter.ToUpper() == "BACKWARD" && quardY > 1)
           {
                quardY -= 1; 
           }
           else if(inputter.ToUpper() == "LEFT" && quardX > 1)
           {
                quardX -= 1; 
           }
           else
           {
                Console.WriteLine($"You can't go any more {inputter.ToLower()}!");
           }
           Console.WriteLine($"({quardX}, {quardY})");
           CheckQuardinates(quardX, quardY);
           
        }
    }

    public void RoomSet()
    {
        Room room1 = new Room();
    }
    public void CheckQuardinates(int X, int Y)
    {
        if(X == 1 && Y == 1)
        {
            Console.WriteLine("You are in room one");
        }
        else if(X == 1 && Y == 2)
        {
            Console.WriteLine("You are in room two");
        }
        else if(X == 1 && Y == 3)
        {
            Console.WriteLine("You are in room three");
        }
    }
}