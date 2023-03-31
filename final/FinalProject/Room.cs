using System;
using System.Collections.Generic;

public class Room
{

    private string _roomDisplay;

    private List<Item> _item;
    private List<Enemy> _enemy;

    public Room(string roomDisplay, List<Item> items, List<Enemy> enemies)
    {
        _roomDisplay = roomDisplay;
        _item = items;
        _enemy = enemies;
    }
    public void Test(Inventory inventory)
    {
        if(EnemyAppear())
        {
            BattleMode(inventory);
            _enemy.Clear();
        }
        if(ItemAppear())
        {
            AddItem(inventory, _item);
        }
        Console.WriteLine(_roomDisplay);
    }
    public Boolean EnemyAppear()
    {
        bool isNullOrEmpty = new bool();
        if (isNullOrEmpty = _enemy?.Any() != true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public Boolean ItemAppear()
    {
        bool isNullOrEmpty = new bool();
        if (isNullOrEmpty = _item?.Any() != true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void AddItem(Inventory invent, List<Item> items)
    {
        items[0].YouGot();
        invent.AddToInventory(items[0]);
        items.Clear();
      
    }

    public void BattleMode(Inventory inventory)
    {
        _enemy[0].Name();

        while (_enemy[0].EnemyAlive() && inventory.IAmDead() != true)
        {
            _enemy[0].CharacterIllustration();
            _enemy[0].ShowHealth();

            inventory.ChooseOptionInBattle(_enemy[0]);
            if(_enemy[0].EnemyAlive() != true)
            {
                _enemy[0].YouDefeatedMe();
            }
            else
            {
                _enemy[0].Attack(inventory);
            }
        }
    }
}