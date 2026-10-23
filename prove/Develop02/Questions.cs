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