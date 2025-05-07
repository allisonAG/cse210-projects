using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a random number
        // Console.Write("What is the magic number? ");
        // int number = int.Parse(Console.ReadLine());

        // Use a random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;
        
        while (guess != number) 
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }

        }
        
    }
}