using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Reference myVerse = new Reference("Alma", 26, 11, 12);
            Scripture myScripture = new Scripture();


            Console.WriteLine(myScripture.GetScripture());
            
        }


    }

}