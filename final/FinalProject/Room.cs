using System;

public class Room
{
    private int _xAxisLoc;
    private int _yAxisLoc;

    private List<Item> _item;
    private List<Enemy> _enemy;


    public Room()
    {
        _xAxisLoc = 0;
        _yAxisLoc = 0;
    }
    public Room(int x, int y)
    {
        _xAxisLoc = x;
        _yAxisLoc = y;
    }
    public void Test()
    {
        Console.WriteLine($"x = {_xAxisLoc}, y = {_yAxisLoc}");
    }
    public Boolean EnemyAppear()
    {
        return true;
    }

    public Boolean ItemAppear()
    {
        return false;
    }
}