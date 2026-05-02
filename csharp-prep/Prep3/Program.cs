using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);

        Console.WriteLine("What is your guess?");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}