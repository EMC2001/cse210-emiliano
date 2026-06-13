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
                Activity breathingActivity = new Activity("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine(breathingActivity.GetActivity());

            }

            else if (userChoice == "2")
            {
            }

            else if (userChoice == "3")
            {
            }

            else if (userChoice == "4")
            {
                break;
            }
        }

    }
}