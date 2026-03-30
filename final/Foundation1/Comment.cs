public class Comment
{
    private string _text;
    private string _author;
    
    // This class is basically just a constructor and some getters.
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public string GetAuthor() => _author;
    public string GetText() => _text;
}