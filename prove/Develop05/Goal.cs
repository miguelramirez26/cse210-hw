// Base class
public abstract class Goal
{
    // Attributes
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    // Constructors
    public Goal(string type, string name, string description, int points)
    {
        _name = name;
        _description = description;
        _type = type;
        _points = points;
        _isComplete = false;
    }

    public Goal(string type, string name, string description, int points, bool isCompleted)
    {
        _name = name;
        _description = description;
        _type = type;
        _points = points;
        _isComplete = isCompleted;
    }

    // Methods
    public abstract void Record(ref int totalPoints);

    // Getters
    public string getType()
    {
        return _type;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    // Setters
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    // Methods
    public virtual void Display()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"[X] | {_name} | {_description}");
        }
        
        else 
        {
            Console.WriteLine($"[ ] | {_name} | {_description}");
        }
    }

    public bool isComplete()
    {
        return _isComplete;
    }

    public virtual int GetRequiredTimes()
    {
        return 0;
    }

    public virtual int GetCompletedCount()
    {
        return 0;
    }

    public virtual int GetBonus()
    {
        return 0;
    }
}