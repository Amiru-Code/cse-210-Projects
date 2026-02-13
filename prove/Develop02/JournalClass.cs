using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private readonly List<Entry> _entries = new List<Entry>();
    private const string separator = "~|~";
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry); 

    }

    public void DisplayAll()
    {
    if(_entries.Count == 0)
        {
            Console.WriteLine("You have no entries"); 
            return;

        }

        for(int i = 0; i < _entries.Count; i += 1)
        {
            Console.WriteLine($"Entry #{i+1} ");
            _entries[i].Display();
        }

    }
    public void SaveToFile(string Filename)
    {
        using (StreamWriter outputfile = new StreamWriter(Filename))
        {
            foreach(var entry in _entries)
            {
                outputfile.WriteLine(entry.ToFileLine(separator)); 
            }
        }find ~ -type d -name ".git" 2>/dev/null | head -n 50
    }

    public void LoadFromFile(string filename)
    {
        var load = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach(var line in File.ReadAllLines(filename))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            if (line.StartsWith("#")) continue;
            var entry = Entry.FromFileLine(line, separator);
            load.Add(entry);

            
        }
        _entries.Clear();
        _entries.AddRange(load);

    }

}