using System;

class Program
{
    static void Main(string[] args)
    {   
        ScriptureLibrary scripLib = new ScriptureLibrary();
        Memorizer mem = new Memorizer();
        int userInput = 0;
        int _scripNum;

        // Two options are given to the user to choose from
        Console.WriteLine("Welcome to the Scripture Memorizer program.");
        Console.WriteLine("\nWhat would you like to do, enter your own scripture or select one from a list?");
        Console.WriteLine("1) Input Scripture \n2) Select Scripture");
        Console.Write("Press 1 or 2: ");
        userInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
      
        // Prompts user how many scriptures would like to have
        if (userInput == 1)
        {
            Console.Write("How many scriptures would you like to have? ");
            _scripNum = Convert.ToInt32(Console.ReadLine());
            scripLib.CreateScripture();
        }

        // The user is provided with scriptures that have already been created
        else if (userInput == 2)
        {
            scripLib.BuildScripture();
        }

        // Displays the scriptures in the list
        foreach (Scripture scripture in scripLib.scripList)
        {
            Console.WriteLine(scripture.GetScriptureText());
            Console.WriteLine();
        }

        // Asks the user to select the scripture to memorize
        Console.Write("Please select the scripture to memorize (enter 1 or 2 or 3, etc): ");
        _scripNum = Convert.ToInt32(Console.ReadLine());
    
        Console.Clear();
        mem.ScriptureMemorizer(scripLib.scripList[_scripNum - 1]);
    }
}