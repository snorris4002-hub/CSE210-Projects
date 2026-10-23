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