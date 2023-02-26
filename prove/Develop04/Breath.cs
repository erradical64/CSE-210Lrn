using System;

class Breath: Activity
{

    public Breath(int duration, string name, string description, List<string> messages):base(duration, name, description)
    {
        _messages = messages;
    }
    public void StartBreathingPls()
    {
        BeginningTheActivity();
        BreathingIn();
        LoadingAnim(4);
        foreach(string m in _messages)
        {
            Console.Write(m);
            CountDownAnim(_duration);
        }
        _duration *= _messages.Count;
        LoadingAnim(5);
        YouHaveCompleted();  

    }
    
    public void BreathingIn()
    {
        _messages.Add("Breath in...");
        _messages.Add("Breath out...");
        _messages.Add("Breath in...");
        _messages.Add("Breath out...");
        _messages.Add("Breath in...");
        _messages.Add("Breath out...");
        _messages.Add("Breath in...");
        _messages.Add("Breath out...");
    }
}