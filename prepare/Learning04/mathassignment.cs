using System;

public class MathAssignment : Assignment
{
    private string _textbookSelection = "1.5";

    private string _problems = "1-39";

    public MathAssignment(string studentName, string topic, string textbookSelection, string problems)
    :base(studentName, topic)
    {
        _problems = problems;
        _textbookSelection = textbookSelection;

        
    }

    public string GetHomeworkList()
    {
        return $"Student name: {StudentName()}, topic: {Topic()}, textbook selection: {_textbookSelection}, problems: {_problems} ";
    }
    
}