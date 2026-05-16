using System;
using System.Collections.Generic;

class Journal
{
    List<Entry> _entries = new List<Entry>();

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
}