using System;

class Scripture
{
 private string _scripture;
 private List<Word> _words = new List<Word>();

 public Scripture()
 {
    _scripture ="But Ammon said unto him: I do not boast in my own strength, nor in my own wisdom; but behold, my joy is full, yea, my heart is brim with joy, and I will rejoice in my God.";

    string[] pieces = _scripture.Split(' ');

    foreach (string piece in pieces)
    {
        _words.Add(new Word(piece));
    }

 }

 public string GetScripture()
    {
        return _scripture;
    }

}