using System;

public abstract class Enemy
{
    protected string _name;
    protected string _description;

    protected int _damage1;
    protected int _damage2;

    protected int _healthPower;

    public Enemy(string name, string desc, int hp, int damage1, int damage2)
    {
        _name = name;
        _description = desc;
        _healthPower = hp;
        _damage1 = damage1;
        _damage2 = damage2;
    }

    public void Name()
    {
        Console.WriteLine($"A {_name} appears in this room!");
    }

    public void EnemyDescription()
    {
        Console.WriteLine(_description);
    }

    public void ShowHealth()
    {
        Console.WriteLine($"{_name.ToUpper()} - [{_healthPower}HP]");
    }
    abstract public void CharacterIllustration();
    public virtual void Attack(Inventory inventory)
    {
        inventory.UnderAttack(_damage1, _damage2); 
    }
    public Boolean EnemyAlive()
    {
        if(_healthPower <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void TakeDamage(int damage)
    {
        _healthPower -= damage;
    }

    public void YouDefeatedMe()
    {
        Console.WriteLine($"You defeated the {_name}!");
    }

    

}