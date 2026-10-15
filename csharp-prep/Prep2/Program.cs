using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        int grade = 0;
        char Letter = 'A';
        Console.WriteLine("Enter your grade (0-100): ");
        string gradeInput = Console.ReadLine();
        grade = int.Parse(gradeInput);
        if (grade >= 90)
        {
             Letter = 'A';
            Console.WriteLine("You got an A!");
            Console.WriteLine("Superb work! you passed with FLYING COLORS!");
        }
        else if (grade >= 80)
        {
             Letter = 'B';
            Console.WriteLine("You got a B!");
            Console.WriteLine("Good job! You passed with a solid score!");
        }
        else if (grade >= 70)
        {
             Letter = 'C';
            Console.WriteLine("You got a C!");
            Console.WriteLine("You passed, Your grade is decent, but what will be improved next time?");
        }
        else if (grade >= 60)
        {
             Letter = 'D';
            Console.WriteLine("You got a D!");
            Console.WriteLine("You did not pass. You were close, but you need to retake the course.");
        }
        else
        {
            Console.WriteLine("You got an F...");
            Console.WriteLine("Were you sleeping in class?");
        }
        // more may be added but the skeleton for the assignment is done


    }
}