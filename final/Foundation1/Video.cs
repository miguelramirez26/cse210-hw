using System;
using System.Collections.Generic;

class Video
{
    // Attributes
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _comments = new List<Comment>();

    // Constructors
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Methods
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumOfComment()
    {
        return _comments.Count();
    }
    
    public void DisplayVideo()
    {
        Console.Write($"{_title} - by {_author}\n");
        Console.Write($"Duration: {_length}\n");
        Console.WriteLine($"Comments: {NumOfComment()} ");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

    }


}