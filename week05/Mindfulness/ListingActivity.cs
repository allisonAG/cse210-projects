using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nGet ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in:");
        ShowCountdown(5);

        GetListFromUser(_duration);

        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> _userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                _userList.Add(input);
            }  
        }

        _count = _userList.Count;
        Console.WriteLine($"\nYou listed {_count} items!");
        return _userList;
    }
}