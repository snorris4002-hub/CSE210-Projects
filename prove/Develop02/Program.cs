
class Program
{
   public static void Main(string[] args)
    {
        var journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write a new entry ");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save journal to file ");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Edit Prompts (gaslight yourself)");
        Console.WriteLine("6. leave :()");

        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            journal.WriteEntry();
        }
        else if (choice == "2")
        {
            journal.DisplayJournal();
        }
        else if (choice == "5")
        {
            journal.EditPrompt();
        }
        else if (choice == "6")
        {
            Console.WriteLine("Goodbye!");
        }
    }

}