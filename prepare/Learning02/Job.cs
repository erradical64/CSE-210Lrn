using System;


public class Job
{
    public string _company;
    public string _jobTitle;

    public int _startYear;
    public int _endYear;

    public int _totalYears;
    public void Display()
    {
        _totalYears = _endYear - _startYear ;
        Console.WriteLine($"{_jobTitle} ({_company}) | {_startYear} - {_endYear} ({_totalYears} years)");
    }


}