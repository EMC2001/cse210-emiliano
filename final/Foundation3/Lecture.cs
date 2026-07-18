class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, int capacity, Address address) : base ("Big Cool Conference", "A super big and super cool conference for everyone who wants to become better", "11/12/2026", "1:00 PM", address)
    {
        _speaker = speaker;
        _capacity = capacity;   
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void DisplayLectureFull()
    {
        DisplayStandardDetails();
        Console.WriteLine("Special Event information:");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

    public void DisplayLectureStandard()
    {
        DisplayStandardDetails();
    }

    public void DisplayLectureShort()
    {
        Console.WriteLine($"Lecture: {GetEventTitle()} {GetDate()}");
    }

    public void DisplayLectureFullInformation()
    {
        Console.Clear();
        Console.WriteLine("Standard Details:" );
        DisplayLectureStandard();
        Console.WriteLine();
        Console.WriteLine("Full Details:" );
        DisplayLectureFull();
        Console.WriteLine();
        Console.WriteLine("Short Details: " );
        DisplayLectureShort();
        Console.WriteLine();
        Console.Write("Please press enter to return to menu:");
        Console.ReadLine();
        Console.Clear();
    }    
}