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
            "Think of a time when you did the right thing. Even if it was hard.",
            "Think of a time when you overcame a difficult task.",
            "Is there a time where you help someone in desperate times?",
            "Who is a hero of yours and why?",
            "What compliments have you received?",
        };

        // Reflection questions
        List<string> reflectionQuestions = new List<string>
        {
            "Why did this mean something to you?",
            "Have you done this since the first time?",
            "What was you process?",
            "How did you feel when it was complete?",
            "What is your favorite thing about this moment?",
            "What did you learn then?",
            "What did you discover about yourself?",
            "What will this change for your future?"
        };

        // Listing prompts
        List<string> listingPrompts = new List<string>
        {
            "Who are some important people in your life?",
            "What are your strengths?",
            "What are you currently working on improving?",
            "Who are people that you helped recently?",
            "When have you felt the Holy Ghost this month?",
        };

        // Listing items
        List<string> listingItems = new List<string>();

        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine();
            Console.WriteLine("Please select an activity with corresponding number:");
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
                        "With slow, breathing, this activity will help clear your mind.",
                        4,
                        4
                    );

                    breathing.Run();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity(
                        "Reflection",
                        "This activity asks yourself questions to help you reflect on your strengths in moments past.",
                        reflectionPrompts,
                        reflectionQuestions,
                        random
                    );

                    reflection.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity(
                        "Listing",
                        "This activity is all about listing things that apply to you in a random subject.",
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