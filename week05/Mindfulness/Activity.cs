public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write($"\nHow long in seconds, would you like for your session? ");

        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }

    public void DisplayEndingMessage()
    {   
        Console.WriteLine("\nWell Done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < futureTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i = (i + 1) % animationStrings.Count;
        } 

    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }
}