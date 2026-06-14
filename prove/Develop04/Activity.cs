using System;
using System.Threading;

class Activity
{
    private string _startMessage;
    private string _description;
    private int _timer;

    public Activity(string startMessage, string description)
    {
        _startMessage = startMessage;
        _description = description;
    }

    public string GetStartMessage()
    {
        return $"{_startMessage}";
    }

    public string GetDescription()
    {
        return $"{_description}";
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
            Console.Write("\b \b");
        }

        Console.Write("  ");
    }

}