/******************************************************************************
* LISTING CS FILE
******************************************************************************/


/*********************************
* LISTING CLASS 
* Derived from the Activity class
* Summary: Display a random prompt and have the user enter as many items as he can. Then show the number of items entered
*********************************/
class Listing : Activity
{
    // Attributes
    List<string> _prompt = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    Random rnd = new Random();
    
    // Constructors
    public Listing()
    {
        // Set start message and display it
        _activityName = "Listing Activity.";
        _activityDescription = "This activity will help you reflect on the good"
        + "things in your life by having you list as many things as you can in a certain area.";
        _startMessage = $"Welcome to the {_activityName} \n\n{_activityDescription}";
        DisplayStartMessage();

        // Prompt the user for the duration of the activity
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        Console.Write("Enter a 10 second interval starting at 10 (i.e. 20, 30, 40...): ");

        // Set end message
        _duration = Convert.ToInt32(Console.ReadLine());
        _endMessage = $"\nYou have completed another {_duration} seconds of the {_activityName}";
    }

    /*********************************
    * DISPLAY PROMPTS
    * Summary: Returns a random prompt
    *********************************/
    public void DisplayPrompts()
    {
        Console.Write(_prompt[rnd.Next(_prompt.Count())]);
    }
    
    /*********************************
    * DISPLAY NUM ITEMS
    * Summary: Returns the number of items
    *********************************/
    public void DisplayNumItems(int _numEntries)
    {
        Console.WriteLine($"You listed {_numEntries} items!");
    }

    public void RunListing()
    {
        int _numEntries = 0;
        // Clear console before listing activity begins
        Console.Clear();

        Console.WriteLine("Get ready...");
        PauseWithSpinner(4);

        Console.Write("\nList as many responses you can to the following prompt:");
        Console.Write("\n --- ");
        DisplayPrompts();
        Console.Write(" ---");
        Console.Write("\nYou may begin in: ");
        PauseWithTimer(5);
        Console.WriteLine();

        while (_duration > 0)
        {
            _startTime = DateTime.Now;

            Console.Write("> ");
            Console.ReadLine();
            _numEntries ++;

            _endTime = DateTime.Now;
            TimeSpan diff = _startTime.Subtract(_endTime);
            double x = diff.TotalSeconds;
            _duration += x;
        }

        DisplayNumItems(_numEntries);

        Console.Write("\n");
        Console.WriteLine("Well done!!");
        PauseWithSpinner(4);

        DisplayEndMessage();
        PauseWithSpinner(4);

        // Clear console after listing activity finished
        Console.Clear();
    }
}