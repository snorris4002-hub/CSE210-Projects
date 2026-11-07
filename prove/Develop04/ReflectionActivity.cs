using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectionActivity(string name, string description,
        List<string> prompts, List<string> questions, Random random)
        : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
        _random = random;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine();
        Slowdown("When you have something in mind, press Enter.",10);
        Console.ReadLine();

        Stopwatch timer = Stopwatch.StartNew();

        while (timer.Elapsed.TotalSeconds < GetDuration())
        {
            Console.WriteLine();
            Console.WriteLine(GetRandomQuestion());

            double remaining = GetDuration() - timer.Elapsed.TotalSeconds;

            int seconds = Math.Min(5, (int)Math.Ceiling(remaining));

            if (seconds <= 0)
                break;

            ShowSpinner(seconds);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
}