using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Journal MyJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int number = 0;

        while (number != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");

            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {

                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                Console.WriteLine("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                MyJournal.AddEntry(entry);
            }

            else if (number == 2)
            {

                MyJournal.DisplayAll();

            }

            else if (number == 3)
            {

                Console.Write("What's the file name? ");
                string fileName = Console.ReadLine();

                MyJournal.SaveToFile(fileName);

            }

            else if (number == 4)
            {
                Console.Write("What's the file name? ");
                string fileName = Console.ReadLine();

                MyJournal.LoadFromFile(fileName);

            }

            else if (number == 5)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Please enter a valid number between 1 and 5.");
            }
        }
    }
}