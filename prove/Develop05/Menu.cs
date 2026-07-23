class Menu
{
    public void DisplayMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Events");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
            }

            else if (userChoice == "2")
            {
            }

            else if (userChoice == "3")
            {
            }

            else if (userChoice == "4")
            {
            }

            else if (userChoice == "5")
            {
            }

            else if (userChoice == "6")
            {
                break;
            }
        }

    }
}