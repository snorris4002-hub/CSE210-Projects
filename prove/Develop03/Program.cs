using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        Console.WriteLine("Scripture Memorizer");
        Console.WriteLine();

        // Get 10 scriptures from the user
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter Scripture #{i + 1}");

            Console.Write("Book: ");
            string book = Console.ReadLine();

            Console.Write("Chapter: ");
            int chapter = int.Parse(Console.ReadLine());

            Console.Write("Verse: ");
            int verse = int.Parse(Console.ReadLine());

            Console.Write("End verse (enter 0 if there isn't one): ");
            int endVerse = int.Parse(Console.ReadLine());

            Console.Write("Scripture text: ");
            string text = Console.ReadLine();

            Reference reference = new Reference(book, chapter, verse, endVerse);
            Scripture scripture = new Scripture(reference, text);

            scriptures.Add(scripture);

            Console.WriteLine();
        }

        // Pick a random scripture
        Random random = new Random();
        int number = random.Next(0, scriptures.Count);

        Scripture selectedScripture = scriptures[number];

        Console.WriteLine("Here is your scripture:");
        Console.WriteLine(selectedScripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Press Enter to hide the words.");
        Console.ReadLine();

        selectedScripture.HideRandomWords(3);

        Console.WriteLine(selectedScripture.GetDisplayText());
    }
}