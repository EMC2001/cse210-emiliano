class Breathing : Activity
{
    public Breathing() : base ("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void BreathingActivity()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(Timer());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            Console.WriteLine();
        }

    }
}