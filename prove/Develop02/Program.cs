using System;

class Program
{
    static void Main(string[] args)
    {
        Entry journalEntry = new Entry();

        Journal myJournal = new Journal();
        myJournal.AddJournalEntry(journalEntry);

        Menu menu = new Menu();
        menu.DisplayMenu();
    }
}