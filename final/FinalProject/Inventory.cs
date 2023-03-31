using System;

public class Inventory
{
    private List<Item> _items;
    private List<string> _attack;
    private List<int> _damage;

    private int _score = 0;
    private List<int> _magicCost;

    private int _health;
    private int _magic;

    public Inventory(List<Item> items, List<string> attack, List<int> damage, List<int> magicCost, int health, int magic)
    {
        _items = items;
        _attack = attack;
        _damage = damage;
        _magicCost = magicCost;
        _health = health;
        _magic = magic;
    }

    public void AddToInventory(Item item)
    {
        _items.Add(item);
    }

    public void ChooseOptionInBattle(Enemy enemy)
    {
        bool yourTurn = new bool();
        yourTurn = true;
        while(yourTurn)
        {
            Console.WriteLine($"1. Attack   2. Items  {_health}HP  {_magic}MP");
            Console.WriteLine("3. Check");
            Console.Write("Select a number: ");
            string option = Console.ReadLine();
            if (option == "1")
            {
                AttackSelect(enemy, yourTurn);
                yourTurn = false;
            }
            else if (option == "2")
            {
                UseItem();
            }
            else if (option == "3")
            {
                enemy.EnemyDescription();
            }
            else
            {
                Console.WriteLine($"'{option}' is not registered as an option.");  
            }
        }
        
    }
    public void DisplayInventory()
    {   
        DisplayItems();
        
        AttackOptions();
    }

    public void DisplayItems()
    {
        Console.WriteLine("Items: ");
        for(int i = 0; i < _items.Count(); i++)
        {
            int numeral = i + 1;
            _items[i].GetName(numeral);
        }
    }

    public void UseItem()
    {
        Console.Clear();
        DisplayItems();
        bool isNullOrEmpty = new bool();
        if (isNullOrEmpty = _items?.Any() != true)
        {
            Console.WriteLine("Looks like you don't have any items!");
        }
        else
        {
            Console.Write("Select an item?: ");
            string selectItem = Console.ReadLine();
            if(selectItem.ToLower() == "yes")
            {
                Console.Write("Which one based on it's number?: ");
                int selected = int.Parse(Console.ReadLine());
                
                if(_items.Count() >= selected)
                {
                    int index = selected - 1;

                    GainHealthAndMagic(_items[index]);

                    _items.RemoveAt(index);
                }
            } 
        }
        
    }


    public void AttackOptions()
    {
        Console.WriteLine("Attacks: ");
        for(int i = 0; i < _attack.Count(); i++)
        {
            int numeral = i + 1;
            if (_magicCost[i] == 0)
            {
                Console.WriteLine($"{numeral}. {_attack[i]} -> inflicts {_damage[i]} to the enemy.");
            }
            else
            {
                Console.WriteLine($"{numeral}. {_attack[i]} -> inflicts {_damage[i]} to the enemy, costs {_magicCost[i]}MP.");
            }
        }
    }
    public void AttackSelect(Enemy enemy, bool yourTurn)
    {
        Console.Clear();
        AttackOptions();
        Console.Write("Select an attack?: ");
        string selectAttack = Console.ReadLine();
        if(selectAttack.ToLower() == "yes")
        {
            Console.Write("Which one based on it's number?: ");
            int selected = int.Parse(Console.ReadLine());
                
            if(_attack.Count() >= selected)
            {
                int index = selected - 1;
                Attack(enemy, index, yourTurn);
            }
        }
    }

    public void Attack(Enemy enemy, int i, bool yourTurn)
    {
        if(_magic >= _magicCost[i])
        {
            enemy.TakeDamage(_damage[i]);
            yourTurn = false;
            _magic -= _magicCost[i];
        }
        else
        {
            Console.WriteLine("Looks like you don't have enough Magic Points");
        }
    }

    public void AssignAttacks()
    {
        Item apple = new Item("apple", "A regular, generic red apple that will restore your health by 15HP.", 15, 0);
        Item tonic = new Item("magic tonic","This tonic will give you 15MP to use to charge up an attack.",0,15);
        _items.Add(apple);
        _items.Add(tonic);
        _items.Add(apple);

        SetAttacks("Sword Slash", 15,0);
        SetAttacks("Launch Arrow", 20,0);
        SetAttacks("Cast Lethal Hex", 100, 50);
    }

    

    public void GainHealthAndMagic(Item item)
    {
        _health += item.heartXtra();
        _magic += item.magXtra();
        item.ApplyMagicAndMagic();
    }

    public void SetAttacks(string name, int damage, int price)
    {
        _attack.Add(name);
        _damage.Add(damage);
        _magicCost.Add(price);
    }

    public void UnderAttack(int r1, int r2)
    {
        Random r = new Random();

        int damageToInflict = r.Next(r1, r2);
        _health -= damageToInflict;
        Console.WriteLine($"You took {damageToInflict} points of damage!\n");
    }

    public void ScoreCompiler()
    {
        _score += (_health * 100) + (_magic * 200) + (_items.Count() * 100);
        Console.WriteLine($"You have a total of {_score} points!");
    }

    public Boolean IAmDead()
    {
        if(_health <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}