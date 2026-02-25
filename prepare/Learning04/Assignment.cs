using System;
using System.Net;

public class Assignment
{
    private string _studentName;

    private string _topic;


    public string GetSummary()
    {
        return $"Student name: {_studentName}, topic: {_topic}";
    }

public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

//Student name getter and setter protected
    protected string StudentName()
    {
        return _studentName;
    }

    protected void StudentName(string name)
    {
        _studentName = name; 
    }


//topic getter and setter protected
    protected string Topic()
    {
        return _topic;
    }

    protected void Topic(string topic)
    {
        _topic = topic;
    }
}