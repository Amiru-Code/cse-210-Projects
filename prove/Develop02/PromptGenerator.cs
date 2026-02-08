using System;

public class PromptGenerator()
{
    private readonly List<string> _prompts = new List<string>()

{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today?",
            "What small win am I grateful for?"
        };


        public void CustomPrompts()
    {
        Console.WriteLine("Enter a Prompt");
        string CustomPrompt = Console.ReadLine();
        _prompts.Add(CustomPrompt); 
    }
        private readonly Random _random = new Random();
        public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}