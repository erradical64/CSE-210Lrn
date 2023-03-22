using System;

public abstract class Enemy
{
    protected string _name;
    protected string _description;
    protected List<int> damage;

    private List<string> _questions;
    private List<string> _answers;


    public Enemy()
    {
        _name = "Null";
    }

    public Enemy(string name)
    {
        _name = name;
    }
    public void CharacterIllustration()
    {
        
    }
    public virtual void Attack()
    {
        
    }
}