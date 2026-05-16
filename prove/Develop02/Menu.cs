using System;

class Menu
{
    public void DisplayMenu()
    {

        Journal myJournal = new Journal();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string userChoice = Console.ReadLine();


            if (userChoice == "1")
            {
                Entry journalEntry = new Entry();
                journalEntry.CreateJournalEntry();
                myJournal.AddJournalEntry(journalEntry);
            }

            else if (userChoice == "2")
            {
                myJournal.DisplayJournal();
            }

            else if (userChoice == "4")
            {
                Journal.SaveJournal(myJournal._entries);
                Console.WriteLine("Your journal has been saved!");
                Console.Clear();
            }

            else if (userChoice == "5")
            {
                break;
            }
        }
    }
}