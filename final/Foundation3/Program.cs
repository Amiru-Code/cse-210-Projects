using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture(
            "Why Sandwiches Should be our friends not food",
            "Sandwiches throughout time have been simply a source of nutrition, this lecture provides a unique perspective about the true feelings of sandwiches",
            "February 32, 1039",
            "25:00 AM",
            new Address("314 sandwich savior dr", "Sandwhichland", "SA", "314159"),
            "Mr. Duckmizer",
            6626
        );

        Reception reception = new Reception(
            "Goose Gala of Greatness",
            "An elegant evening of enjoyment hosted by our favorite siily goose Goose Goosington",
            "Neverember 64, 505",
            "1:00 AM",
            new Address("440 Gooseway", "Gooseville", "GS", "121"),
            "rsvp@GooseGoosinton.com"
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Duck Feeding Contest", "Feed your local duck the most food possible, the person who feeds their duck most wins!",
            "Duckmass 2.3, 3323",
            "32:34 PM",
            new Address("4 Duckway", "DuckTown", "83263", "DU"), 
            "Bad weather, -273.15C, Hurricane Winds, Overall Great weather for feeding ducks!"
        );

        List<Event> events = new List<Event> {lecture, reception, outdoorGathering};

        foreach(Event i in events)
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine("--- Standard Details ---");
            Console.WriteLine(i.GetStandardDetails());
            Console.WriteLine("\n--- Full Details ---");
            Console.WriteLine(i.GetFullDetails());
            Console.WriteLine("\n--- Short Descriptions ---");
            Console.WriteLine(i.GetShortDescription());
            Console.WriteLine();
        }
    }
}