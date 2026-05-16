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
}