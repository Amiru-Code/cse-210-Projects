using System;


class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Joel the discount ostrich", "economics");
        MathAssignment math = new MathAssignment("Samwise the potato lover", "sandwiches","32.4", "2-6" );
        WritingAssignment writing = new WritingAssignment("boberton III of north sandwichlandia ", "history of pidgeons", "Pidgeions, the spies from above");

        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine(writing.GetWritingInformation());
    }
}