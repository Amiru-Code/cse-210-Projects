using System;

public class WritingAssignment : Assignment
{

    
    private string _title = "The Hobbit";

    public WritingAssignment(string studentName, string topic, string title)
    :base(studentName, topic)
    {
        _title = title;
    }


    public string GetWritingInformation()
    {
        return $"Student name: {StudentName()}, topic: {Topic()}, book title: {_title}";
    }
    
}