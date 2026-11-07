using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    private int _breatheInSeconds;
    private int _breatheOutSeconds;

    public BreathingActivity(string name, string description,
        int breatheIn, int breatheOut)
        : base(name, description)
    {
        _breatheInSeconds = breatheIn;
        _breatheOutSeconds = breatheOut;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Stopwatch timer = Stopwatch.StartNew();

        while (timer.Elapsed.TotalSeconds < GetDuration())
        {
            double remaining = GetDuration() - timer.Elapsed.TotalSeconds;

            int seconds = Math.Min(
                _breatheInSeconds,
                (int)Math.Ceiling(remaining));

            if (seconds <= 0)
                break;

            Console.WriteLine();
            Slowdown("Breathe in...",1000);
            ShowCountdown(seconds);

            remaining = GetDuration() - timer.Elapsed.TotalSeconds;

            seconds = Math.Min(
                _breatheOutSeconds,
                (int)Math.Ceiling(remaining));

            if (seconds <= 0)
                break;

            Console.WriteLine();
            Slowdown("Breathe out...",1000);
            ShowCountdown(seconds);
        }

        DisplayEndingMessage();
    }
}