using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write ("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int intNumber = int.Parse(number);
        return intNumber;
    }

    static int PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year: ");
        string birthYearString = Console.ReadLine();
        birthYear = int.Parse(birthYearString);
        return birthYear;
    }

    static int SquareNumber(int intNumber, string name)
    {
        int squaredNumber = intNumber * intNumber;
        return squaredNumber;
    }

    static void DisplayResult(int squaredNumber, string name, int birthYear)
    {
        int currentYear = 2026;
        int age = currentYear - birthYear;
        Console.WriteLine($"{name}, the square of your number is: {squaredNumber}");
        Console.WriteLine($"{name}, you are {age} years old.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int squaredNumber = SquareNumber(number, name);
        DisplayResult(squaredNumber, name, birthYear);
    }
}