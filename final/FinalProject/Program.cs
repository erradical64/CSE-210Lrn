using System;

class Program
{
    static void Main(string[] args)
    {
        List<Room> leftCenter = new List<Room>();
        List<Room> left = new List<Room>();
        List<Room> right = new List<Room>();
        List<Room> rightCenter = new List<Room>();

        Maze aMazing = new Maze(right, rightCenter, left, leftCenter);
        Console.Clear();
        aMazing.NavigateRooms();
        Console.Clear();
        Console.WriteLine("Game Over");
    }
}