class Prompt
{
    List<string> _prompts = new List<string>() 
    {"Who was the most interesting person I interacted with today? ", "What was the best part of my day? ", 
    "How did I see the hand of the Lord in my life today? ", "What was the strongest emotion I felt today? ", 
    "If I had one thing I could do over today, what would it be? "};

    Random _randomGenerator = new Random();

    public string getPrompt ()
    {
        return _prompts[_randomGenerator.Next(0, 4)];
    } 
}