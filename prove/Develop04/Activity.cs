using System;
using System.Threading;
using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void DisplayStartingMessage()
    {
        Slowdown($"Welcome to the {_name} Activity.", 25);
        Console.WriteLine();
        Slowdown(_description, 20);
        Console.WriteLine();

        Slowdown("How long, in seconds, would you like for your session? ", 20);
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Slowdown("Please enter a positive whole number: ", 25);
        }

        Console.WriteLine();
        Console.WriteLine("Ready...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Slowdown("Good job!", 20);
        Slowdown($"You have completed the {_name} Activity!", 20);
        Slowdown($"You spent {_duration} seconds on this activity!", 20);

        ShowSpinner(3);
    }

    protected void ShowSpinner(float seconds)
    {
        Stopwatch timer = Stopwatch.StartNew();
        string[] animation = { "|", "/", "-", "\\" };
        int i = 0;

        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Console.Write(animation[i % animation.Length]);
            Thread.Sleep(100);
            Console.Write("\b");
            i++;
        }

        Console.Write(" ");
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void Slowdown(string text, int speed)
    {
        foreach (char letter in text)
        {
        Console.Write(letter);
        Thread.Sleep(20);
    }
    Console.WriteLine();
    }

}