public class Activity
{
    protected int _activityDuration;
    protected string _starterText;
    protected Random _rand;

    public Activity()
    {
        
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
            Animation.Spinner(3); // brief pause before starting
            Console.WriteLine();
        }

    protected void EndMessage(string activityName)
    {
        Console.WriteLine("\nWell done!");
        Animation.Spinner(2);   

        Console.WriteLine($"\nYou have completed the {activityName} for {_activityDuration} seconds.");    
        Animation.Spinner(3);
        Console.WriteLine();
    }


}