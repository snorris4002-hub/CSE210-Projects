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