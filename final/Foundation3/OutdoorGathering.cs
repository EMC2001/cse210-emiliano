class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string weather, Address address) : base ("Big Outdoor Activity", "We will have great farmer's market in order to help our local business owners (Please be aware event can be cancelled due to weather conditions)", "07/04/2026", "12:00 PM", address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public void DisplayOutdoorGatheringFull()
    {
        DisplayStandardDetails();
        Console.WriteLine("Special Event information:");
        Console.WriteLine($"Weather Conditions: {_weather}");
    }

    public void DisplayOutdoorGatheringStandard()
    {
        DisplayStandardDetails();
    }

    public void DisplayOutdoorGatheringShort()
    {
        Console.WriteLine($"Outdoor Gathering: {GetEventTitle()} {GetDate()}");
    }

    public void DisplayOutdoorGatheringInformation()
    {
        Console.Clear();
        Console.WriteLine("Standard Details:" );
        DisplayOutdoorGatheringStandard();
        Console.WriteLine();
        Console.WriteLine("Full Details:" );
        DisplayOutdoorGatheringFull();
        Console.WriteLine();
        Console.WriteLine("Short Details: " );
        DisplayOutdoorGatheringShort();
        Console.WriteLine();
        Console.Write("Please press enter to return to menu:");
        Console.ReadLine();
        Console.Clear();
    }    
}