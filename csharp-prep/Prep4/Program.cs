using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>();

        int userNum = -1;
        while (userNum != 0)
       {
            Console.Write("Enter a number! (0 to end the program): ");
            string userResponse = Console.ReadLine();
            userNum = int.Parse(userResponse);

            if (userNum != 0)
            {
                num.Add(userNum);
            }
        }
                int sum = 0;
        foreach (int number in num)
        {
            sum += number;
        }

        Console.WriteLine($"The total sum is: {sum}");
        float average = ((float)sum) / num.Count;
        Console.WriteLine($"The average is: {average}");
        int max = num[0];
        foreach (int number in num)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}