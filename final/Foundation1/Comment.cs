using System;

class Comment
{
    private string _userName;
    private string _text;

    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_userName}");
        Console.WriteLine($"'{_text}'");
    }
}