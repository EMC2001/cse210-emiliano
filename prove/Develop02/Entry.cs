using System;

class Entry
{
    string _date;
    string _response;
    string _prompt;

    string[] _prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How can I improve my day tomorrow?",
        "What is something I am grateful for today?",
        "How did I improve myself today?"
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
        Console.WriteLine($"{_date} {_prompt} {_response}");
    }

    public string CreateFileSystemString()
    {
        return $"{_date} {_prompt} {_response}";
    }

}