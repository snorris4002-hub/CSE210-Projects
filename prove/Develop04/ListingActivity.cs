using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;
    private Random _random;

    public ListingActivity(string name, string description,
        List<string> prompts, List<string> items, Random random)
        : base(name, description)
    {
        _prompts = prompts;
        _items = items;
        _random = random;
    }

    public void Run()
    {
        DisplayStartingMessage();

        int index = _random.Next(_prompts.Count);

        Console.WriteLine();
        Slowdown("List as many responses as you can to the following prompt:", 15);
        Console.WriteLine();
        Console.WriteLine(_prompts[index]);

        Console.WriteLine();
        Slowdown("You may begin in...",10);
        ShowCountdown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing items!");

        _items.Clear();

        Stopwatch timer = Stopwatch.StartNew();
        string currentItem = "";

        while (timer.Elapsed.TotalSeconds < GetDuration())
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                
                if (key.Key == ConsoleKey.Enter)
                {
                    if (!string.IsNullOrWhiteSpace(currentItem))
                    {
                        _items.Add(currentItem);
                        currentItem = "";

                        Console.WriteLine();
                        Console.WriteLine(">");
                    }
                }
                else if (key.Key == ConsoleKey.Backspace)
                {
                    if (currentItem.Length > 0)
                    {
                        currentItem = currentItem.Substring(
                            0, currentItem.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    currentItem += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }
            else
            {
                Thread.Sleep(50);
            }
        }

        if (!string.IsNullOrWhiteSpace(currentItem))
        {
            _items.Add(currentItem);
        }

        Console.WriteLine();
        DisplayItemCount();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomItem()
    {
        if (_items.Count == 0)
            return "";

        int index = _random.Next(_items.Count);
        return _items[index];
    }

    private void DisplayItemCount()
    {
        Console.WriteLine();
        Slowdown($"You listed {_items.Count} items!", 15);
    }
}