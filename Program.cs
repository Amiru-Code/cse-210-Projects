using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
     

        Console.WriteLine("Enter an adjective: ");
        string adjective1 = Console.ReadLine();

        Console.WriteLine("Enter an animal: ");
        string animal1 = Console.ReadLine();
        

        Console.WriteLine("Verb past tense: ");
        string verbPast1 = Console.ReadLine();

        Console.WriteLine("Enter an adverb: ");
        string adverb1 = Console.ReadLine();


        Console.WriteLine("Enter an adjective: ");
        string adjective2 = Console.ReadLine();

        Console.WriteLine("Enter a noun: ");
        string noun1 = Console.ReadLine();

        Console.Write("enter an animal: ");
        string animal2 = Console.ReadLine();

        Console.Write("enter an adjective: ");
        string adjective3 = Console.ReadLine();

        Console.Write("enter an verb: ");
        string verb1 = Console.ReadLine();

        Console.Write("enter an adverb: ");
        string adverb2 = Console.ReadLine();

        Console.Write("enter a verb past tense: ");
        string verbPast2 = Console.ReadLine();

        Console.Write("enter an adverb: ");
        string adverb3 = Console.ReadLine();

        Console.Write($@"Today I went to the zoo. I saw a(n) {adjective1} {animal1} jumping up and down in its
        a tree. It {verbPast1} {adverb1} through the large tunnel that led to its {adjective2} {noun1}.
         I got some peanuts and passed them through the cage to a gigantic gray {animal2} towering above my head. Feeding that animal made me hungry.
          I went to get a {adjective2} scoop of ice cream. It filled my stomach. Afterwards, I had to {verb1} {adverb2} to catch our bus.
           When I got home, I {verbPast2} my mom for a {adjective3} day at the zoo.");

        






        Console.WriteLine("Enter an adverb");
        Console.ReadLine();
    }
}