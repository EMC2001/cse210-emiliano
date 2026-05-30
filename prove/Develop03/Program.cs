using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Hello");
        Console.WriteLine(myWord.GetWordString());

        myWord.Hide();
        Console.WriteLine(myWord.GetWordString());

        myWord.DisplayWord();
        if (myWord.isHidden())
        {
            Console.WriteLine(myWord.GetWordString());
        }

        Scripture myScripture = new Scripture();
        Console.WriteLine(myScripture.GetScripture());


    }

}