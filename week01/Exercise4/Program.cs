using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;
        
        while (userNumber != 0)
        {
            Console.Write("Enter number (0 to quit): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        int largestNumber = numbers[0];


        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber) 
            {
                largestNumber = number;
            }
        }

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average  is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        
    }
}