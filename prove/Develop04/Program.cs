using System;
using System.IO.Compression;

//I added a session tracker that keeps count of how many mindful activities the user completes during their current run of the program.
// It displays this summary when they choose to quit.

class Program
{

    private static int _loadingTime = 1; 
static void Main()
        {
        Console.Title = "Mindfulness Activities";
        int activitiesCompleted = 0; // Exceeding requirements tracker

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  1. Start breathing activity");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  2. Start reflecting activity");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  3. Start listing activity");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  4. Quit");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Select a choice from the menu: ");
            
            string input = Console.ReadLine();

            if (input == "1")
            {

            Console.ForegroundColor = ConsoleColor.Cyan;
                new Breathing().Run();
                activitiesCompleted++;
            }
            else if (input == "2")
            {
            Console.ForegroundColor = ConsoleColor.Magenta;
                new Reflecting().Run();
                activitiesCompleted++;
            }
            else if (input == "3")
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
                new Listing().Run();
                activitiesCompleted++;
            }
            else if (input == "4")
            {
            Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\nYou completed ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{activitiesCompleted}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" mindful activities this session.\n");
                Console.WriteLine("Thanks for using the Mindfulness App. See you next time!");
                Thread.Sleep(2000);
                break;
            }
            else
            {
            Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid option, please try again.");
                Thread.Sleep(1500);
            }    }
        }

private static List<string> _options = new()
    {
         "1. Start Breathing activity",
         "2. Start reflecting activity",
         "3. Start listing activity", 
         "4. Quit"
    };


    
    static void Loading(int loadingTime)
    {
        Console.WriteLine("loading");
        Activity.Spinner(loadingTime / 1000);
        Console.WriteLine();
    }


    static int UserOptions()
    {
        Console.Clear();
        Console.WriteLine("Mindfulness activities");
        Console.WriteLine("-------------------------------");
        foreach(string i in _options)
        {
            Console.WriteLine(i);
        };
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Select an option from the menu: ");
        while (true)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out int option) && option >= 1 && option <= _options.Count)
            return option;
            Console.Write("Invalid option please try again. ");
        }    }


    static void ActivityLoop(int option)
    {
        Loading(_loadingTime);

        switch (option)
            {
                case 1:
                    new Breathing().Run();
                    break;
                case 2:
                    new Reflecting().Run();
                    break;
                case 3:
                    new Listing().Run();
                    break;
            }

    
        
        
    }

}