using System;

class Memorizer
{
    public void ScriptureMemorizer(Scripture scripture)
    {
        Console.Write(scripture.GetReference().GetReference());
        Console.Write(" ");
        scripture.DisplayWords();
        Console.WriteLine();

        // When all words hidden or user enters quit then the program ends
        Console.WriteLine("\nPress enter to continue or type 'quit' to finsh:");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "quit")
        {
            System.Environment.Exit(0);
        }
            
        Console.Clear(); 

        // While loop to keep the program running until all words are hidden or quit is entered
        while (true)
        {
            List<Word> _shownWords = scripture.WordsShown();
            Random rnd = new Random();

            if (_shownWords.Count() == 0)
            {
                break;
            }
            
            for (int i=0; i < 3; i++)
            {
                int num = rnd.Next(_shownWords.Count());
                _shownWords[num].SetHidden(true);
            }
            
            // Once the three words are hidden, it displays the rest of the scripture word by word
            Console.Write(scripture.GetReference().GetReference());
            Console.Write(" ");
            scripture.DisplayWords();
            Console.WriteLine();

            // When all words hidden or user enters quit then the program ends
            Console.WriteLine("Press enter to continue or type 'quit' to finsh:");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            
            Console.Clear();
        }

    }
}