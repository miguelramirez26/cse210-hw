using System;

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    string filename;

    public void AddEntry()
    {
       Entry _entry = new Entry();
       _entry.Write();
       _entryList.Add(_entry);
    }

    public void Display()
    {
        Console.WriteLine(_entryList.Count);
        
        
        foreach (Entry _entry in _entryList)
        {
            Console.WriteLine($"Date: {_entry._date} - Prompt: {_entry._prompt}");
            Console.WriteLine($"{_entry._response}\n");
        }
    }      

    public void Load()
    {
        Console.WriteLine("What is the file name? ");
        filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the file name? ");
        filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
            foreach (Entry _entry in _entryList)
            {
                outputFile.WriteLine($"Date: {_entry._date} - Prompt: {_entry._prompt} \n{_entry._response}\n");
            }
    }  
    // public void Remove ()
    // {

    // }
}