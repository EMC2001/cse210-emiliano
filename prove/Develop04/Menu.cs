class Menu
{
    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Breathing breathing = new Breathing();
                breathing.GetStartMessage();
                breathing.GetDescription();
                breathing.BreathingActivity();
            }

            else if (userChoice == "2")
            {
                Reflecting reflecting = new Reflecting("Welcome to the Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            }

            else if (userChoice == "3")
            {
                Listing listing = new Listing("Welcome to the Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            }

            else if (userChoice == "4")
            {
                break;
            }
        }

    }
}