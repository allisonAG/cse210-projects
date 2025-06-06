public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nGet ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(4);

            Console.Write("Now breathe out...");
            ShowCountdown(6);

        }

        DisplayEndingMessage();
        ShowSpinner(5);
        

    }

}