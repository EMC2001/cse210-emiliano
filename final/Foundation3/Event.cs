using System;
using System.Dynamic;

class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event (string eventTitle,string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_eventTitle}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_time}");
        Console.WriteLine(_address.GetAddress());
    }
}