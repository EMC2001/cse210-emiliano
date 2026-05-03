using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }
            else
            {
                numbers.Add(number);
            }
        }

        int sumTotal = numbers.Sum();
        double avgTotal = numbers.Average();
        int largeNumber = numbers.Max();
        
        Console.WriteLine($"The sum is: {sumTotal}");
        Console.WriteLine($"The average is: {avgTotal}");
        Console.WriteLine($"The largest number is: {largeNumber}");

    }
}