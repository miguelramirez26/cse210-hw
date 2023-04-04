using System;

class Comment
{
    // Attributes
    private string _userName;
    private string _text;

    // Constructors
    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }

    // Methods
    public void DisplayComment()
    {
        Console.WriteLine($"{_userName}");
        Console.WriteLine($"'{_text}'");
    }
}