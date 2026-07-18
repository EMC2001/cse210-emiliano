using System;
using System.ComponentModel.DataAnnotations;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    
    public void DisplayVideo()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length} seconds");
    }
}