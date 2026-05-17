using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddJournalEntry(Entry journalEntry)
    {
        _entries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public static void SaveJournal(List<Entry> entries)
    {
        Console.WriteLine("What would you like to name your file?");
        string fileName = Console.ReadLine() + ".txt";

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public static List<Entry> LoadJournal()
    {
        Console.WriteLine("What File would you like to load?");
        string fileName = Console.ReadLine() + ".txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return new List<Entry>();
    }
}