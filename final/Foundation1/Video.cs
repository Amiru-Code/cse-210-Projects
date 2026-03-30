using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Video
{
    private List<Comment> _comments = new List<Comment>();
    private string _title;
    private string _author;
    private int _duration;
    
    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }
    // Adds a comment to the list and the return type is just the current instance of Video
    public Video AddComment(Comment comment)
    {
        _comments.Add(comment);
        return this;
    }

    // returns the number of comments in the list.
    public int NumComment()
    {
        return _comments.Count();
    }

    // I need these getters in my program class.
    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetDuration() => _duration;
    public List<Comment> GetCommentInfo() => _comments;
}