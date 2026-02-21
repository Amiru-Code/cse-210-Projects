using System;
using System.Formats.Asn1;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter 1 for Ether, enter 2 for Proverbs Enter 3 for random");

        string verseNum = Console.ReadLine();
        string text;

        if(verseNum == "3")
        {
                    Random random = new Random(); 
        verseNum = random.Next(1,3).ToString();
        }



        if(!string.IsNullOrWhiteSpace(verseNum) && verseNum.Trim() == "2")
        {
         // Example multi verse scripture Proverbs 3:5–6 
        var referenceMulti = new Reference("Proverbs", 3, 5, 6);
         text =
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        var scripture = new Scripture(referenceMulti, text);



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
        

        if(!string.IsNullOrWhiteSpace(verseNum) && verseNum.Trim() == "1")
                {
                    var referenceSingle = new Reference("Ether", 12, 27);
                     text = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
                     var scripture = new Scripture(referenceSingle, text);
                     


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

        
        

}  }