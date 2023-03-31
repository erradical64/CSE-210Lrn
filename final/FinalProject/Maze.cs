using System;

public class Maze
{
    public bool test = true;
    private List<Room> _migiHeya, _migiNakaHeya, _hidariNakaHeya, _hidariHeya;

    public Maze(List<Room> right, List<Room> rightCenter, List<Room> left, List<Room> leftCenter)
    {
        _migiHeya = right;
        _migiNakaHeya = rightCenter;
        _hidariHeya = left;
        _hidariNakaHeya = leftCenter;

        
    }
    public void NavigateRooms()
    {
        int quardX = 1;
        int quardY = 1;

        List<Item> items = new List<Item>();
        List<string> attack = new List<string>();
        List<int> damage = new List<int>();
        List<int> mCost = new List<int>();

        Inventory invent = new Inventory(items, attack, damage, mCost, 55, 50);
        invent.AssignAttacks();

        Anim anim = new Anim();

        List<string> roomLayoutL = new List<string>();
        anim.AddLayoutsL(roomLayoutL);
        List<string> roomLayoutLC = new List<string>();
        anim.AddLayoutsLC(roomLayoutLC);
        List<string> roomLayoutR = new List<string>();
        anim.AddLayoutsR(roomLayoutR);
        List<string> roomLayoutRC = new List<string>();
        anim.AddLayoutsRC(roomLayoutRC);


        RoomSet(_hidariHeya, roomLayoutL, 3);
        RoomSet(_hidariNakaHeya, roomLayoutLC, 5);
        RoomSet(_migiHeya, roomLayoutR, 5);
        RoomSet(_migiNakaHeya, roomLayoutRC, 5);

        
        while (test)
        {
            if(invent.IAmDead() != true)
            {
                Console.Write("Left, Right, Forward, Backward, Inventory, or Quit?\nYou can even input by 'L', 'R', 'F', 'B', 'I' and 'Q': ");
                string inputter = Console.ReadLine();
                Console.WriteLine("Going that direction...");
                anim.Spinner(2);
                Console.Clear();
                if ((inputter.ToUpper() == "RIGHT" || inputter.ToUpper() == "R") && quardX < 4 && quardY > 1)
                {
                        quardX += 1;
                }
                else if((inputter.ToUpper() == "FORWARD" || inputter.ToUpper() == "F") && (quardY < 4 && quardX < 4 || quardY < 5 && quardX == 4))
                {
                        quardY += 1;
                }
                else if((inputter.ToUpper() == "BACKWARD" || inputter.ToUpper() == "B") && quardY > 1)
                {
                        if (quardX > 1 && quardY == 2)
                        {
                            Console.WriteLine($"You can't go any more further that way!");
                        }
                        else
                        {
                            quardY -= 1;
                        }
                }
                else if((inputter.ToUpper() == "LEFT" || inputter.ToUpper() == "L") && quardX > 1)
                {
                    quardX -= 1; 
                }
                else if(inputter.ToUpper() == "INVENTORY" || inputter.ToUpper() == "I")
                {
                    invent.DisplayInventory();
                }
                else if((inputter.ToUpper() == "FORWARD" || inputter.ToUpper() == "F") && quardX == 4 && quardY == 5)
                {
                    Console.WriteLine("You escaped!");
                    anim.Spinner(3);
                    test = false;
                }
                else if((inputter.ToUpper() == "QUIT" || inputter.ToUpper() == "Q"))
                {
                    test = false;
                }
                else
                {
                    Console.WriteLine($"You can't go any more further that way!");
                }
                CheckQuardinates(quardX, quardY, invent);   
            }
            else
            {
                Console.WriteLine("YOU DIED!");
                anim.Spinner(3);
                test = false;
            }
        }
        Console.Clear();
        invent.ScoreCompiler();
        anim.Spinner(2);
    }

    public void RoomSet(List<Room> room, List<string> stringer, int nullify)
    {
        
        for(int i = 0; i < stringer.Count(); i++)
        {
            List<Item> itemTest = new List<Item>(); 
            List<Enemy> enemyTest = new List<Enemy>();
            
            if (i != nullify)
            {
                ItemOrEnemy(itemTest, enemyTest);
            }

            room.Add(new Room(stringer[i], itemTest, enemyTest));
        }
    }

    public void CheckQuardinates(int X, int Y, Inventory invent)
    {

        if(X == 1)
        {
            int indexGet = (4 - Y);
            _hidariHeya[indexGet].Test(invent);
        }

        if(X == 2)
        {
            int indexGet = (4 - Y);
            _hidariNakaHeya[indexGet].Test(invent);
        }
        if(X == 3)
        {
            int indexGet = (4 - Y);
            _migiNakaHeya[indexGet].Test(invent);
        }
        if(X == 4)
        {
            
            int indexGet = (4 - Y + 1);
            _migiHeya[indexGet].Test(invent);
        }
    }

    public void ItemOrEnemy(List<Item> itemTest, List<Enemy> enemyTest)
    {
        Random r = new Random();

        int noOne = r.Next(1,4);
        int noTwo = r.Next(1,3);

        if (noOne == 2)
        {
            if (noTwo == 2)
            {
                itemTest.Add(new Item("magic tonic","This tonic will give you 15MP to use to charge up an attack.",0,15));
            }
            else if(noTwo == 1)
            {
                List<string> q = new List<string>();
                List<string> a = new List<string>();
                enemyTest.Add(new Sphynx("", "", 40, q, a, 10, 16));
                itemTest.Add(new Item("healing stone","This jewel can be found in the hands of sphynxs, whom are too cocky to use it, it heals 40HP and 45MP before disintegrating into dust.",40,45));
            }
        }
        else if (noOne == 3)
        {
            if (noTwo == 2)
            {
                List<string> q = new List<string>();
                List<string> a = new List<string>();
                enemyTest.Add(new Sphynx("", "", 35, q, a, 5, 16));
            }
            else if(noTwo == 1)
            {
                enemyTest.Add(new Wyvern("", "", 45, 15, 21));
            }
        }
    }

}
