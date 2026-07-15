using System;

class Scripture
{
 private string _scripture;
 private List<Word> _words = new List<Word>();

 public Scripture(string scripture)
 {
    _scripture = scripture;

    string[] pieces = _scripture.Split(' ');

    foreach (string piece in pieces)
    {
        _words.Add(new Word(piece));
    }

 }

public string GetScripture()
{
    string letter = "";

    foreach (Word word in _words)
    {
        letter += word.GetWordString() + " ";
    }

    return letter.Trim();
}

private Random _random = new Random();

public void HideWords()
{
    int index;

    do
    {
        index = _random.Next(_words.Count);
    }
    while (_words[index].isHidden());

    _words[index].Hide();
}

public bool WordsHidden()
{
    foreach (Word word in _words)
    {
        if (!word.isHidden())
        {
            return false;
        }
    }

    return true;
}

}