using System;

class Scripture
{
    public List<Word> wordsList = new List<Word>();
    private string _scriptureText;

    private Reference _scriptureReference;

    // Constructors
    public Scripture (Reference _scriptureReference, string _scriptureText)
    {
        this._scriptureReference = _scriptureReference;
        this._scriptureText = _scriptureText;
        string[] _storeParse = _scriptureText.Split(" ");
        foreach (string word in _storeParse)
        {
            Word wordObj = new Word(word);
            wordsList.Add(wordObj);
        }
    }

    // Gets the scripture text
    public string GetScriptureText()
    {
        return _scriptureText;
    }

    // List of words shown
    public List<Word> WordsShown()
    {
        List<Word> _wordsShown = new List<Word>();
        foreach (Word _word in wordsList)
        {
            if (_word.GetHidden() == false)
            {
                _wordsShown.Add(_word);
            }
        }

        return _wordsShown;
    }

    public Reference GetReference()
    {
        return _scriptureReference;
    }

    public void DisplayWords()
    {
        foreach (Word _word in wordsList)
        {
            _word.DisplayWord();
            Console.Write(" ");
        }
    }
}

