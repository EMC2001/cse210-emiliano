using System.Collections.Generic;

class Listing : Activity
{
    private string _prompt;
    public List<string> _entries = new List<string>();
    public Listing() : base ("Listing Activity", "Welcome to the Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Good Job!")
    {
        
    }

    string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void ListingActivity()
    {
        Random random = new Random();
        int randomPrompt = random.Next(_prompts.Length);
        _prompt = _prompts[randomPrompt];

        DisplayStartingMessage();

        Console.Clear();
        Console.Write("Get Ready...");
        ShowAnimation();
        Console.WriteLine();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--{_prompt}--");
        Console.WriteLine();

        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(Timer());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(">");
            string entry =Console.ReadLine();
            _entries.Add(entry);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_entries.Count} items!");
        Thread.Sleep(5000);

        Console.WriteLine();
        DisplayEndMessage();
        
        
    }
}