using System;
class Program
{
    static void Main(string[] args)
    {
        Reference myVerse = new Reference("Alma", 26, 11, 12);
        Scripture myScripture = new Scripture(
            "But Ammon said unto him: I do not boast in my own strength, nor in my own wisdom; but behold, my joy is full, yea, my heart is brim with joy, and I will rejoice in my God. " +
            "Yea, I know that I am nothing; as to my strength I am weak; therefore I will not boast of myself, but I will boast of my God."
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(myVerse.GetReference());
            Console.WriteLine(myScripture.GetScripture());

            Console.WriteLine();
            Console.Write("Press enter to remove a word or type 'quit' to finish the program:");
            string enterInput = Console.ReadLine();

            if (enterInput == "quit")
            {
                break;
            }

            if (myScripture.WordsHidden())
            {
                break;
            }

            myScripture.HideWords();
        }


    }

}