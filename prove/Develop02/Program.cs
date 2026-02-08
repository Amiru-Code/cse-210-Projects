using System;
using System.ComponentModel;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Text;


class Program
{
    private static Journal _journal = new Journal(); 
    private static PromptGenerator _prompts = new PromptGenerator(); 
    public static void Main(string[] args)
    {
        ShowMenu();
    }

    private static void ShowMenu()
    {
        bool runing = true; 

        while(runing == true)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("(1) Write a new entry");
            Console.WriteLine("(2) Display the journal");
            Console.WriteLine("(3) Save the journal to a file");
            Console.WriteLine("(4) Load the journal from a file");
            Console.WriteLine("(5) Add new prompt");

            Console.WriteLine("(6) Quit");
            Console.WriteLine("Select an option 1-6: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                WriteNewEntry();
                break; 
                case "2": 
                DisplayJournal();
                break;
                case "3":
                SaveJournal();
                break; 
                case "4":
                LoadJournal();
                break; 
                case "5":
                AddPrompt();
                break;
                case "6":
                Console.WriteLine("Thank you for using the journal! ");
                runing = false; 
                break;


                default: 
                Console.WriteLine("Please enter a valid option 1-5");
                break;

            }

        }
    }

    private static void WriteNewEntry()
    {
        string prompt = _prompts.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Press enter on an empty line to exit: ");

        StringBuilder sb = new StringBuilder();
        string line;
        while(!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            sb.AppendLine(line);
        }
        string response = sb.ToString(); 
        string today = DateTime.Now.ToString("MM-dd-yyyy");

        var entry = new Entry()
        {
            _date = today,
            _prompt = prompt,
            _entry = response
        };

        _journal.AddEntry(entry); 
        Console.WriteLine("Entry added");

    }

    private static void DisplayJournal()
    {
        _journal.DisplayAll();
    }

    private static void SaveJournal()
    {
        Console.Write("Enter a filename ex(Journal.txt)");
        string filename = Console.ReadLine();
        if (string.IsNullOrEmpty(filename))
        {
            Console.WriteLine("Invalid filename Save canceled ");
            return; 
        }
        try
        {
            _journal.SaveToFile(filename); 
        Console.WriteLine($"File saved as {filename}" );
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving file" + ex.Message);
        }
    }
    private static void LoadJournal()
    {
        Console.WriteLine("Enter the name of the file you want to load from: ");
        string filename = Console.ReadLine();
        if(string.IsNullOrEmpty(filename))
        {
            Console.WriteLine("Invalid Filename Load canceled");
            return;
        }
        try
        {
            _journal.LoadFromFile(filename);
            Console.WriteLine($"Your file has been successfully loaded from {filename+ System.IO.Path.GetFullPath(filename)}, all entries have been replaced.");
        
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Load failed with error code {ex.Message}");
            Console.WriteLine("Current working directory: " + Environment.CurrentDirectory);
        }
    }

    private static void AddPrompt()
    {
        _prompts.CustomPrompts();
    }
    
}
