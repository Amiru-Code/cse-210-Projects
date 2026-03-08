using System.Net.Http.Headers;
using System.Reflection;

public class Reflecting: Activity
{
    private string _initialDisplay = "";
    private List<string> _prompts = new()
    {
        
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."

    };

    private List<string> _questions = new()
    {
        
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };

    public void Run()
    {
        _initialDisplay = "This activity will help you reflect on times in your life when you have shown strength and resilience. ";

        StartMessage("Reflection Activity", _initialDisplay);

        RandPrompt(delay: 5);

        UserReflect(duration: _activityDuration);

        EndMessage("Reflection Activity");
    }

    public string GetInitial()
    {
        return _initialDisplay;
    }

    public void RandPrompt(int delay)
    {
        var prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine("Consider the following prompt");
        Console.WriteLine(prompt);

        Console.WriteLine("When you have something to write press enter to continue");
        Console.ReadLine();
        Console.WriteLine("You may begin in");
        Animation.Countdown(delay);
        Console.WriteLine();
    }

    public void UserReflect(int duration)
    {
        var end = DateTimeOffset.Now.AddSeconds(duration);
        int questionDelaySeconds = 2;

        // ask questions while the requested duration has not yet passed
        while (DateTimeOffset.Now < end)
        {
            string q = _questions[_rand.Next(_questions.Count)];
            Console.WriteLine(q);
            Console.ReadLine();
            Console.WriteLine("Thinking ");
            Animation.Spinner(questionDelaySeconds);
            Console.Clear();
        }
        
    }
} 

