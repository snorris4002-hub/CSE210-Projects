using System;

public class Job
{
    public string _jobtitle;
    public string _company;
    public int _startYr;
    public int _endYr;
    public void Display()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startYr}-{_endYr}");
    }
}
