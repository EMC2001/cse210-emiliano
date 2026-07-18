using System;
using System.ComponentModel.DataAnnotations;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List <Comment>();
    
    public void DisplayVideo()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length} seconds");
        CommentNumber();
        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("-----------------------------");
    }

    public void CommentNumber()
    {
        Console.WriteLine($"Total number of comments: {_comments.Count}");
    }
}