/******************************************************************************
* ACTIVITY CS FILE
******************************************************************************/


/*********************************
* ACTIVITY CLASS 
* Base class
* Summary: Set attributes and methods to be inherited by subclasses
*********************************/
class Activity
{
    // Attributes
    protected string _startMessage;
    protected string _activityName;
    protected string _activityDescription;
    protected double _duration;
    protected string _endMessage;
    protected DateTime _startTime;
    protected DateTime _endTime;
    List<string> animationStrings = new List<String>()
        {
            "|",
            "/",
            "-",
            "\\",
        };

    // Constructor
    public Activity()
    {}

    // Methods
    /*********************************
    * DISPLAY START MESSAGE
    * Summary: Returns a brief explation of the activity along with its name
    *********************************/
    public void DisplayStartMessage()
    {
        Console.WriteLine(_startMessage);
    }

    /*********************************
    * DISPLAY END MESSAGE
    * Summary: Returns a brief 
    *********************************/
    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
    }

    /*********************************
    * PAUSE WITH SPINNER
    * Summary: Returns a spinner animation
    *********************************/
    public void PauseWithSpinner(int duration)
    {
        while (duration > 0)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            } 
            duration -= 2;
        }
    }
    
    /*********************************
    * PAUSE WITH TIMER
    * Summary: Returns a countdown timer
    *********************************/
    public void PauseWithTimer(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            _duration --;
        }
    }
}