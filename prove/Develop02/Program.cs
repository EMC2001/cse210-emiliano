using System;

class Program
{
    static void Main(string[] args)
    {
        Entry journalEntry = new Entry();
        journalEntry.CreateJournalEntry();
        journalEntry.DisplayJournalEntry();
    }
}