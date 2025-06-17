using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        string date = DateTime.Now.ToShortDateString();
        Running r1 = new Running(date, "Running", 30, 4.8);
        activities.Add(r1);

        Cycling c1 = new Cycling(date, "Cycling", 30, 9.7);
        activities.Add(c1);

        Swimming s1 = new Swimming(date, "Swimming", 30, 5);
        activities.Add(s1);

        foreach (Activity a in activities)
        {
            string summary = a.GetSummary();
            Console.WriteLine(summary);
        }

    }
}