using System;

class Add
{
    public int firstNum;
    public int secondNum;
    public int sum;

    private string privateOne = "3";
    public int summed;

    public string Privatized()
    {
        return privateOne;
    }
    public void Addition()
    {
        sum = firstNum + secondNum;
    }
    

    public void AddThis(string one, string two)
    {
        
        summed = int.Parse(two) + int.Parse(one);
    }
}
        