class Reception : Event
{
    private string _emailContent;

    public Reception(string emailContent, Address address) : base ("Big Cool Wedding", "A super big and super cool wedding for everyone related to the newly weds", "04/17/2026", "8:00 PM", address)
    {
        _emailContent = emailContent;   
    }

    public string GetEmailContent()
    {
        return _emailContent;
    }
    public void DisplayReceptionStandard()
    {
        DisplayStandardDetails();
    }

    public void DisplayReceptionFull()
    {
        DisplayStandardDetails();
        Console.WriteLine("Special Event information:");
        Console.WriteLine($"Email Content: {_emailContent}");
    }

    public void DisplayReceptionShort()
    {
        Console.WriteLine($"Reception: {GetEventTitle()} {GetDate()}");
    }

    public void DisplayReceptionFullInformation()
    {
        Console.Clear();
        Console.WriteLine("Standard Details:" );
        DisplayReceptionStandard();
        Console.WriteLine();
        Console.WriteLine("Full Details:" );
        DisplayReceptionFull();
        Console.WriteLine();
        Console.WriteLine("Short Details: " );
        DisplayReceptionShort();
        Console.WriteLine();
        Console.Write("Please press enter to return to menu:");
        Console.ReadLine();
        Console.Clear();
    } 
}