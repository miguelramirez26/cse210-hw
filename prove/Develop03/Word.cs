using System;

class Word
{
    // Attributes
    private string _word;
    private bool _hidden;
    
    public Word(string word)
    {
       _word = word;
       _hidden = false;
    }

    // Getters and Setters
    // Set hidden
    public void SetHidden(bool hidden)
    {
        _hidden = hidden;
    }
    
    // Get hidden
    public bool GetHidden()
    {
        return _hidden;
    }
    
    // Get the word string
    public void DisplayWord()
    {
        if (_hidden == true)
        {
            foreach(char letter in _word)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(_word);
        }
    }
}