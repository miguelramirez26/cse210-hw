using System;

class Reference
{
    // Attributes
    private string _reference;

    // Reference constructors
    public Reference(string book, int chapter, int startVerse)
    {
        _reference = $"{book} {chapter}:{startVerse}";
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _reference = $"{book} {chapter}:{startVerse}-{endVerse}";   
    }

    public string GetReference()
    {   
        return _reference;
    }
}