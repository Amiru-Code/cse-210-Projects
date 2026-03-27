public class Activity
{
    protected int _activityDuration;
    protected string _starterText;
    protected Random _rand;

    public Activity()
    {
        _rand = new Random();
    }

    public int UserDuration()
    {
        Console.WriteLine("How long would you like to do your activity?: ");
        
        while (true)
             {
             var input = Console.ReadLine();
             if (int.TryParse(input, out int secs) && secs > 0)
             {
                 _activityDuration = secs;
                 return secs;
             }
             Console.Write("Please enter a positive whole number of seconds: ");
             }
            

    }


    protected void StartMessage(string activityName, string description)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {activityName}.\n");
            Console.WriteLine(description + "\n");

            UserDuration();

            Console.Write("\nGet ready...");
            Activity.Spinner(3); // brief pause before starting
            Console.WriteLine();
        }

    protected void EndMessage(string activityName)
    {
        Console.WriteLine("\nWell done!");
        Activity.Spinner(2);   

        Console.WriteLine($"\nYou have completed the {activityName} for {_activityDuration} seconds.");    
        Activity.Spinner(3);
        Console.WriteLine();
    }


    public static void Spinner(int seconds)
    {

        char[] _spin = {'|', '/', '-', '\\'};
        var end = DateTimeOffset.Now.AddSeconds(seconds);
        int i = 0; 
        // continue spinning until I reach the target time
        while (DateTimeOffset.Now < end)
        {
            Console.Write($"\r{_spin[i % _spin.Length]} ");
            Thread.Sleep(60); 
            i ++; 
        }
        Console.Write("\r \r"); 
    }

    public static void Countdown(int seconds)
    {
        for(int s = seconds; s >= 1; s--)
        {
            Console.WriteLine(s);
            Thread.Sleep(1000);
        }
    }



}