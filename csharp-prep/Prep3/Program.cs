using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random numGenerator = new Random();
        int hiddenNumber = numGenerator.Next(1,101);

        int choice = -1;
        while (choice != hiddenNumber)
        {
            Console.Write("Input your answer:");
            choice = int.Parse(Console.ReadLine());
// conditions based on the persons choice
            if (hiddenNumber < choice)
                Console.WriteLine("Lower.");

            else if (hiddenNumber > choice)
                Console.WriteLine("Lower");
            
            else
                Console.WriteLine("Congratulations! That was the Number!");
        }
    }
}