using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        int number = 0;

        while (number != 6)
        {   
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                CreateGoal();
            }

            else if (number == 2)
            {
                ListGoalDetails();
            }

            else if (number == 3)
            {
                Console.Write("What's the file name? ");
                string fileName = Console.ReadLine();
                SaveToFile(fileName);
            }
            else if (number == 4)
            {
                Console.Write("What's the file name? ");
                string fileName = Console.ReadLine();
                LoadFromFile(fileName);
            }
            else if (number == 5)
            {
                RecordEvent();
            }

            else if (number == 6)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Please enter a valid number between 1 and 5.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The Goals are:");
        int index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}. {g.GetName()}");
            index++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}. {g.GetDetailsString()}");
            index++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("\nWhich type of goal would you like to create? ");
        int number = int.Parse(Console.ReadLine());


        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (number == 1)
        {
            newGoal = new SimpleGoal(name, description, points);
        }

        else if (number == 2)
        {
            newGoal = new EternalGoal(name, description, points);
        }

        else if (number == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            newGoal = new CheckListGoal(name, description, points, target, bonus);
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
        }

    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplished? ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= _goals.Count)
        {
            Goal selectedGoal = _goals[number - 1];
            selectedGoal.RecordEvent();

            int pointsEarned = 0;

            if (selectedGoal is CheckListGoal clg)
            {
                pointsEarned = clg.GetEarnedPoints();
            }
            else
            {
                pointsEarned = selectedGoal.GetPoints(); 
            }

            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        }

    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            Goal newGoal = null;

            if (type == "SimpleGoal")
            {   
                bool isComplete = bool.Parse(parts[4]);
                newGoal = new SimpleGoal(name, description, points, isComplete);
            }

            else if (type == "EternalGoal")
            {
                newGoal = new EternalGoal(name, description, points);
            }

            else if (type == "ChecklistGoal")
            {
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                newGoal = new CheckListGoal(name, description, points, target, bonus);
            }

            if (newGoal != null)
            {
                _goals.Add(newGoal);
            }

        }

        Console.WriteLine($"Goals loaded from {file}.");
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Goal newGoal in _goals)
            {
                outputFile.WriteLine(newGoal.GetStringRepresentation());
            }

            Console.WriteLine($"Journal saved to {file}");
        }
    }
}   
