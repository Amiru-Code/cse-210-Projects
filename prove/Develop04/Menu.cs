using System.Globalization;

public class Menu
{
    private List<string> _options = new()
    {
         "1. Start Breathing activity",
         "2. Start reflecting activity",
         "3. Start listing activity", 
         "4. Quit"
    };
    private int _loadingTime = 1; 


    public Menu() : this(100){}

    public Menu(int loadingTime)
    {
        _loadingTime = loadingTime;

    }
    
    public void Loading(int loadingTime)
    {
        Console.WriteLine("loading");
        Animation.Spinner(loadingTime / 1000);
        Console.WriteLine();
    }


    public int UserOptions()
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


    public void ActivityLoop(int option)
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