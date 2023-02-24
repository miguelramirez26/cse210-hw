/******************************************************************************
* REFLECTION CS FILE
******************************************************************************/


/*********************************
* REFLECTION CLASS 
* Derived from the Activity class
* Summary: Display a random prompt with random related questions 
*********************************/
class Reflection : Activity
{
    // Attributes
    // Manually build lists
    List<string> prompts = new List<String>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    // List of questions
    List<string> questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    List<string> questionsCopy;
    // Random class obj
    Random rnd = new Random();
    

    // Constructors
    public Reflection()
    {
        // Set start message and display it
        _activityName = "Reflection Activity.";
        _activityDescription = "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _startMessage = $"Welcome to the {_activityName} \n{_activityDescription}";
        DisplayStartMessage();

        // Prompt the user for the duration of the activity
        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
        Console.Write("Enter a 12 second interval starting at 12 (i.e. 24, 36, 48...): ");

        // Set end message
        _duration = Convert.ToInt32(Console.ReadLine());
        _endMessage = $"\nYou have completed another {_duration} seconds of the {_activityName}";
    }

    // Methods
    public void DisplayPrompt()
    {
        // Use rnd to generate a random prompt and display it
        Console.Write(prompts[rnd.Next(prompts.Count())]);
    }

    // DisplayQuestions()
    public void DisplayQuestions()
    {
        // Use rnd to generate random question and display it
        // Remove question from list
        int i = rnd.Next(questionsCopy.Count());
        Console.Write("> ");
        Console.Write(questionsCopy[i]);
        Console.Write(" ");
        questionsCopy.Remove(questionsCopy[i]);
    }

    public void RunReflection()
    {
        // Clear console before reflection activity begins
        Console.Clear();
        
        questionsCopy = questions;
        // Display prompt
        Console.WriteLine("Get ready...");
        PauseWithSpinner(4);

        Console.Write("\nConsider the following prompt:");
        Console.Write("\n\n --- ");
        DisplayPrompt();
        Console.Write(" ---");

        Console.WriteLine("\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        // Display questions
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        PauseWithTimer(5);

        Console.Clear();

        while (_duration > 0)
        {
            DisplayQuestions();
            PauseWithSpinner(12);
            _duration -= 12;
            Console.WriteLine();
        }

        // Display end message
        Console.Write("\n");
        Console.WriteLine("Well done!!");
        PauseWithSpinner(4);

        DisplayEndMessage();
        PauseWithSpinner(4);

        // Clear console after reflection activity finished
        Console.Clear();
    }
}