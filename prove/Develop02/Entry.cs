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
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Length);
        Console.WriteLine(_prompts[randomPrompt]);
        _response = Console.ReadLine();
        _prompt = _prompts[randomPrompt];
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt} {_response}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date}, {_prompt} {_response}";
    }

}