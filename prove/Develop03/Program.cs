using System;

public class Program
{
    public static void Main()
    {
        // Example scripture Proverbs 3:5–6 
        var reference = new Reference("Proverbs", 3, 5, 6);
        string text =
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        var scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (scripture.AllWordsHidden)
            {
                break;
            }

            // Hide a few words per iteration.
            scripture.HideRandomWords(count: 3, onlyUnhidden: true);

            if (scripture.AllWordsHidden)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}