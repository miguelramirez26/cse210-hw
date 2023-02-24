/******************************************************************************
* BREATHING CS FILE
******************************************************************************/


/*********************************
* BREATHING CLASS 
* Derived from the Activity class
* Summary: Display a series of messages alternating between "Breathe in..." and "Breathe out..."
*********************************/
class Breathing : Activity
{
    // Constructor
    public Breathing()
    {
        // Set start message and display it
        _activityName = "Breathing Activity.";
        _activityDescription = "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        _startMessage = $"Welcome to the {_activityName} \n{_activityDescription}";
        DisplayStartMessage();

        // Prompt the user for the duration of the activity
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        Console.Write("Enter a 10 second interval starting at 15 (i.e. 25, 35, 45...): ");

        // Set end message
        _duration = Convert.ToInt32(Console.ReadLine());
        _endMessage = $"\nYou have completed another {_duration} seconds of the {_activityName}";
    }

    // Methods
    public void RunBreathing()
    {
        // Clear console before breathing activity begins
        Console.Clear();

        Console.WriteLine("Get ready...");
        PauseWithSpinner(4);

        Console.Write("\n\nBreathe in...");
        PauseWithTimer(2);
        Console.Write("\nNow breathe out...");
        PauseWithTimer(3);

        // While duration > 0
        // Breathe in
        // Pause 4
        // Breathe out
        // Pause 6
        while (_duration > 0)
        {
            Console.Write("\n\nBreathe in...");
            PauseWithTimer(4);
            Console.Write("\nNow breathe out...");
            PauseWithTimer(6);
        } 

        // Display end message
        Console.Write("\n\n");
        Console.WriteLine("Well done!!");
        PauseWithSpinner(4);

        DisplayEndMessage();
        PauseWithSpinner(4);

        // Clear console after breathing activity finished
        Console.Clear();
    }
}