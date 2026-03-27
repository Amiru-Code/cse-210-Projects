public class Listing: Activity
{
    private string _initialDisplay;
    private List<string> _prompts = new()
    {  
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    }; 

    public void Run()
    {
        
        _initialDisplay = "This activity will help you reflect on the good things in your life by having you list as many things as you can. ";
        StartMessage("Listing Activity", _initialDisplay );

        RandPrompt(delay: 5);
        int count = ListIdeas(_activityDuration);
        Console.WriteLine($"You listed {count} items. ");
        EndMessage("Listing Activity");

    }
    public string GetInitial()
    {
        return _initialDisplay;
    }

    public void RandPrompt(int delay)
    {
        var prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine("List as many responses as you can to the following prompt");
        Console.WriteLine(prompt);

        Console.WriteLine("You may begin in ");
        Activity.Countdown(delay);
        Console.WriteLine();
    }

    public int ListIdeas(int duration)
    {
        var end = DateTimeOffset.Now.AddSeconds(duration);
        int count = 0;

        Console.WriteLine("Start listing items. Press enter after each item.");

        while(DateTimeOffset.Now < end)
        {
            Console.Write("|");
            string line = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(line))
            count ++;
        }
        return count;
    }
    
}