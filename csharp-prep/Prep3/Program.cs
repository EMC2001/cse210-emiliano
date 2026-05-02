using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        while (true)
        {
            Console.Write("What is your guess? ");
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
            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}