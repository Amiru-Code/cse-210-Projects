using System;
using System.Dynamic;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Entry
{
    public string _date {get; set;} = "";
    public string _prompt {get; set;} = "";
    public string _entry  {get; set;} = "";
    
    public void Display()
    {
        Console.WriteLine("----------------------------------------------------------------------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine("Response");
        Console.WriteLine(_entry);
        Console.WriteLine("-----------------------------------------------------------------------------------------");

    }
    public string ToFileLine(string separator)
    { 
        return $"{_date}{separator}{_prompt}{separator}{_entry}";

    }

    public static Entry FromFileLine(string line, string separator="~|~")
    {
        var _parts = line.Split(separator, StringSplitOptions.None); 
        if(_parts.Length < 3)
        {
            throw new FormatException("Invalid format in file: ");

        }
    
        return new Entry
        {
            _date = _parts[0],
            _prompt = _parts[1],
            _entry = _parts[2]
    };
     
    
    }


}