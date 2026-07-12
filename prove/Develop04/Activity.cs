using System;
using System.Threading;

class Activity
{
    private string _startMessage;
    private string _description;
    private string _endMessage;
    private string _activity;
    private int _timer;

    public Activity(string activity, string startMessage, string description, string endMessage)
    {
        _activity = activity;
        _startMessage = startMessage;
        _description = description;
        _endMessage = endMessage;
    }

    public string GetActivity()
    {
        return $"{_activity}";
    }

    public string GetStartMessage()
    {
        return $"{_startMessage}";
    }

    public string GetDescription()
    {
        return $"{_description}";
    }

    public string GetEndMessage()
    {
        return $"{_endMessage}";
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(GetStartMessage());
        Console.WriteLine();
        Console.WriteLine(GetDescription());
        Console.WriteLine();
        SetTimerDuration();
    }

    public void SetTimerDuration()
    {
        Console.WriteLine("How long in seconds, would you like for your session to be?");
        _timer = int.Parse(Console.ReadLine());
    }

    public string GetTimerEndMessage()
    {
        return $"You have completed {_timer} seconds of the {_activity}";
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine(GetEndMessage());
        Console.WriteLine(GetTimerEndMessage());
        Thread.Sleep(5000);
    }

    public int Timer()
    {
        return _timer;
    }

    public  void ShowCountDown(int seconds)
    {
        int count = seconds;
        DateTime endTime = DateTime.Now.AddSeconds(count);

        while (DateTime.Now < endTime)
        {
            Console.Write($"{count--,2}");
            Thread.Sleep(1000);
            Console.Write("\b \b \b\b");
        }
    }

    public void ShowAnimation()
    {
    DateTime endTime = DateTime.Now.AddSeconds(6);

    while (DateTime.Now < endTime)
        {
            Console.Write("\\");
            Thread.Sleep(600);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(600);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(600);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(600);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(600);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(600);
            Console.Write("\b \b");
        }
        
    }

}