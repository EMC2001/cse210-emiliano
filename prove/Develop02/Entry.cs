using System;

class Entry
{
    string _date;
    string _response;
    string _prompt;

    string[] _prompts = {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "What did you learn today?",
        "What made you smile today?",
        "What is something you want to improve on?"
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();
        Console.WriteLine(_prompts[0]);
        _response = Console.ReadLine();
        _prompt = _prompts[0];
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }

}