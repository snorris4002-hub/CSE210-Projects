using System;

class Program
{
    static void Main(string[] args)
    {
        // Where information is put into the program
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int sqNum = SquareNumber(userNum);
        int birthYear;
        PromptUserBirthYear(out birthYear);
        DisplayResult(userName, sqNum, birthYear);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Birthday Calculator!");
        Console.WriteLine("You will input the required information to determined how old you will be this year.");
        Console.WriteLine("In addition to the calculator, we added a favorite number squarinator as DLC to thsi program. We now own your soul as a result.");
    }

    static string PromptUserName()
    {
        Console.Write("Start with your first (or full) name: ");
        string name = Console.ReadLine();
        return name;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write($"Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int PromptUserNumber()
    //Half time number question
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    
    static int SquareNumber(int number)
    {
        int sqnum = number * number;
        return sqnum;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, Your squared number is {square}.");
        Console.WriteLine($"{name}, you will be {2025 - birthYear} years old this year!");
    }
}