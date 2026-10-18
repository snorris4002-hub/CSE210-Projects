using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your first name: ");
        string fName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string lName = Console.ReadLine();
        Console.WriteLine($"Your name is {lName}, {fName}, {lName}!");
    }
}