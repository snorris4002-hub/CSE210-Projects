using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        // Reflection prompts
        List<string> reflectionPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Reflection questions
        List<string> reflectionQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different from other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };

        // Listing prompts
        List<string> listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // Listing items
        List<string> listingItems = new List<string>();

        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine();
            Console.WriteLine("Please select an activity:");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity(
                        "Breathing",
                        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                        4,
                        4
                    );

                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity(
                        "Reflection",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                        reflectionPrompts,
                        reflectionQuestions,
                        random
                    );

                    reflection.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity(
                        "Listing",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                        listingPrompts,
                        listingItems,
                        random
                    );

                    listing.Run();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Thanks for using this program!");
                    break;

                default:
                    Console.WriteLine("Thats not a choice. Please select using 1-4");
                    break;
            }

            if (running)
            {
                Console.WriteLine();
                Console.WriteLine("Press the Enter key to return to the menu.");
                Console.ReadLine();
            }
        }
    }
}