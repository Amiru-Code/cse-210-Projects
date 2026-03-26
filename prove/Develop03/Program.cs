using System;
using System.Formats.Asn1;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter 1 for D&C, enter 2 for Proverbs Enter 3 for random");

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
                    var referenceSingle = new Reference("The standard of truth", 1, 1);
                     text = "The standard of truth has been erected. No unhallowed hand can stop the work from progressing; persecutions may rage, mobs may combine, \n armies may assemble, calumny may defame, but the truth of God will go forth boldly, nobly, and independent till it has penetrated every continent, \n visited every clime, swept every country, and sounded in every ear, till the purposes of God shall be accomplished\n and the great Jehovah shall say the work is done.";
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