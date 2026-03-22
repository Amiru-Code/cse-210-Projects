using System;

class Program
{
    static GoalManager _manager = new GoalManager();
    static GoalfileHandler _filehandeler = new GoalfileHandler();

    static void Main(string[] args)
    {
        bool running = true;
        
        while (running)
        {
         ShowMenu();
         string choice = Console.ReadLine();
         Console.Clear();

         switch (choice)
            {
                case "1": _manager.DisplayPlayerInfo(); break;
                case "2": _manager.ListGoalDetails(); break;
                case "3": CreateGoalMenu(); break; 
                case "4": RecordEventMenu(); break;
                case "5": SaveMenu(); break;
                case "6": LoadMenu(); break;
                case "7": running = false; break;
                default: Console.WriteLine("Invalid Choice Try again."); break;
                

            }

        }
        Console.WriteLine("Goodbye!");
    }
    static void ShowMenu()
    {
        Console.WriteLine("\n======== Eternal Quest ========");
        Console.WriteLine($"Score: {_manager.GetScore()} | Level {_manager.GetLevel()}");
        Console.WriteLine("1. Display player info");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Create new goal");
        Console.WriteLine("4. Record event");
        Console.WriteLine("5. Save goals");
        Console.WriteLine("6. Load goals");
        Console.WriteLine("7. Quit");
        Console.Write("Choice: ");
    }

    static void CreateGoalMenu()
    {
        Console.WriteLine("\n-- Create Goal --");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.WriteLine("4. Negative goal");
        Console.WriteLine("5. Streak goal");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.WriteLine("Name?: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
            _manager.AddGoal(new SimpleGoal(name, description, points, false));
            break;

            case "2":
            _manager.AddGoal(new EternalGoal(name, description, points, 0));
            break;

             case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _manager.AddGoal(new ChecklistGoal(name, description, points, target, 0, bonus));
                break;

            case "4":
                Console.Write("Penalty points: ");
                int penalty = int.Parse(Console.ReadLine());
                _manager.AddGoal(new NegativeGoal(name, description, 0, 0, penalty));
                break;

            case "5":
                Console.Write("Required streak (days): ");
                int required = int.Parse(Console.ReadLine());
                Console.Write("Streak bonus points: ");
                int streakBonus = int.Parse(Console.ReadLine());
                _manager.AddGoal(new StreakGoal(name, description, points, 0, 0, required, streakBonus, DateTime.Now));
                break;

            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
         Console.WriteLine($"Goal '{name}' created!");
    }

    static void RecordEventMenu()
    {
        var goals = _manager.GetGoals();

        if(goals.Count == 0)
        {
            Console.WriteLine("No goals yet");
            return;
        }
        Console.WriteLine("\n--Record Event");
        _manager.ListGoalDetails();

        Console.Write("Which goal did you complete? (number): ");
        if (!int.TryParse(Console.ReadLine(), out int index) || 
        index < 1 || index > goals.Count)
        {
          Console.WriteLine("Invalid selection. ");
          return;  
        }

        int pointsEarned = _manager.RecordEvent(index -1);

        if(pointsEarned < 0)
        {
            Console.WriteLine($"+{pointsEarned} points");
        }
        else if (pointsEarned < 0)
        Console.WriteLine($"{pointsEarned} points");
        else 
        Console.WriteLine("No points");
        
    }

    static void SaveMenu()
    {
        Console.Write("filename to save: ");
        string filename = Console.ReadLine();
        _filehandeler.Save(filename, _manager.GetScore(), _manager.GetGoals());
        Console.WriteLine("Saved!");
    }

    static void LoadMenu()
    {
        Console.Write("filename to load: ");
        string filename = Console.ReadLine();

        try
        {
            var (score, goals) = _filehandeler.Load(filename);
            _manager.SetData(score, goals);
            Console.WriteLine("Loaded!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not Found");
        }
        
    }
}