using System;

class Program
{
    static void Main(string[] args)
    {

        int number = 0;

        while (number != 4)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.Clear();
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.Run();
                Console.Clear();
            }

            else if (number == 2)
            {
                Console.Clear();
                ListingActivity listingActivity1 = new ListingActivity();
                listingActivity1.Run();
                Console.Clear();
            }

            else if (number == 3)
            {
                Console.Clear();
                ReflectingActivity reflectingActivity1 = new ReflectingActivity();
                reflectingActivity1.Run();
                Console.Clear();
            }

            else if (number == 4)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Please enter a valid number between 1 and 4.");
            }
        }     

    }
}