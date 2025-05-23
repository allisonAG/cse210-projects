using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 7);
        Console.WriteLine(reference.GetDisplayText());

        Scripture scripture = new Scripture(reference, "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Console.WriteLine(scripture.GetDisplayText());
        
        while (!scripture.isCompletelyHidden())
        {

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(5);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
        
        

    }
}