using System;

class Program
{

static void Main()
        {
            Console.Title = "Mindfulness Activities";

            // Optional loading/intro animation time in milliseconds
            var menu = new Menu(loadingTime: 1500);

            while (true)
            {
                int option = menu.UserOptions();
                if (option == 4)  // Quit
                {
                    Console.WriteLine("\nThanks for using the Mindfulness App. See you next time!");
                    Animation.Spinner(seconds: 2);
                    break;
                }

                menu.ActivityLoop(option);
            }
        }
}