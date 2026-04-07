using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("14 Mar 1592", 65, 35.89),
            new Cycling("9 July 3238", 46, 26.38),
            new Swimming("3 Feb 1971", 69, 39)
        };

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}