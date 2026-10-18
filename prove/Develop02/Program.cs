
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
public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private Questions _questions = new Questions();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void WriteEntry()
    {
        string prompt = _questions.GetRandomPrompt();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        AddEntry(new Entry(date, prompt, response));
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void EditPrompt()
    {
        _questions.EditPrompt();
    }
}

public class Questions
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was something new I learned today?",
        "What was the strongest emotion I felt this week?",
        "If I had one thing I could do over today, what would it be?",
        "What am I feeling today?",
        "Who could use some prayers or service?",
        "Do I want to make a mustard cupcake?",
        "What is my favorite game and why?",
        "If I had a million dollars, what would I do?",
        "Did I meet any cool animals today?",
        "Would I rather, get stabbed up to 10 times but get 10,000 dollars a stab? OR Would I rather Loose my sight in the light, But I gain perfect night vision?",
        "Why am I using this subar Journal?",
    };

    public string GetRandomPrompt()
    {
        int index = Random.Shared.Next(_prompts.Count);
        return _prompts[index];
    }

    public void EditPrompt()
    {
        Console.WriteLine("Which prompt would you like to edit?");

        for (int i = 0; i < _prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_prompts[i]}");
        }

        Console.Write("Enter the number of the prompt: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) ||
            choice < 1 || choice > _prompts.Count)
        {
            Console.WriteLine("Invalid prompt number.");
            return;
        }

        Console.Write("Enter the new prompt: ");
        string newPrompt = Console.ReadLine();

        _prompts[choice - 1] = newPrompt;

        Console.WriteLine("Prompt updated successfully!");
    }
}

public class Entry
{
    public string _timeCurrent { get; set; }
    public string _Prompt { get; set; }
    public string _Response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        _timeCurrent = date;
        _Prompt = prompt;
        _Response = response;
    }
    

    public void Display()
    {
        Console.WriteLine($"Date: {_timeCurrent}");
        Console.WriteLine($"Prompt: {_Prompt}");
        Console.WriteLine($"Response: {_Response}");
    }
}
}