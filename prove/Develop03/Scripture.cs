using System;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>{};

    private Random _random = new Random(); 


    public Scripture(Reference reference, string text)
    {
        _reference = reference ?? throw new ArgumentNullException(nameof(reference));
        if (text is null) throw new ArgumentNullException(nameof(text));

        _words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(token => new Word(token)).ToList();

    }

    public bool AllWordsHidden => _words.All(w => w.IsHidden);

    public void HideRandomWords(int count = 3, bool onlyUnhidden = true)
    {
        if(count <= 0 || _words.Count == 0 || AllWordsHidden) return; 
        IEnumerable<int> pool = onlyUnhidden ? _words.Select((w,i) => (w,i)).Where(p => !p.w.IsHidden).Select(p => p.i)
        : Enumerable.Range(0, _words.Count);

        var indices = pool.ToList();
        if(indices.Count == 0) return;

        for(int i = indices.Count -1; i>0; i--)
        {
            int j = _random.Next(i+1);
            (indices[1], indices[j]) = (indices[j], indices[i]);
        }

        foreach(int idx in indices.Take(Math.Min(count, indices.Count)))
        {
            _words[idx].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference}\n\n{text}";
    }
}