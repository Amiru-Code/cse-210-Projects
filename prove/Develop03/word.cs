using System;


public class Word
{
    private string _text;

    private bool _isHidden;

//Constructor for text
    public Word(string text)
    {
       
        _text = text ?? string.Empty;
        _isHidden = false;
    }

    public bool IsHidden => _isHidden; 
    public void Hide() => _isHidden = true;

    public void Show() => _isHidden = false;

    public string GetDisplayText()
    {
       if (!_isHidden) return _text;
       // Keep punctuation, masks only letters and digits
       var masked = _text.Select(c => char.IsLetterOrDigit(c) ? '_':c).ToArray();
       return new string(masked);
    }
}