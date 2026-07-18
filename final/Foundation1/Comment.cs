using System;

public class Comment
{
    public string _user;
    public string _commentText;
    public void DisplayComment()
    {
        Console.WriteLine($"User: {_user}");
        Console.WriteLine($"Comment: {_commentText}");
        Console.WriteLine();
        
    }
}