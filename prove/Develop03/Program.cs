using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        Word myWord = new Word("Hello");
        Console.WriteLine(myWord.GetWordString());

        myWord.Hide();
        Console.WriteLine(myWord.GetWordString());

        myWord.DisplayWord();
        if (myWord.isHidden())
        {
            Console.WriteLine(myWord.GetWordString());
        }

        Reference myVerse = new Reference("Alma", 26, 11, 12);
        Console.WriteLine(myVerse.GetReference());

        Scripture myScripture = new Scripture();
        Console.WriteLine(myScripture.GetScripture());


    }

}