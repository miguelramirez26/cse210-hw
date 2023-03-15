class Checklist : Goal
{
    // Set these to private
    private int _requiredTimes;
    private int _bonus;
    private int _completedCount;

    // Add another constructor that does not take completedCount or isCompleted
    public Checklist(string type, string name, string description, int points, int requiredTimes, int bonus) : base(type, name, description, points)
    {
        // Set required times
        // Set bonus
        // Set completedCount = 0
        _requiredTimes = requiredTimes;
        _bonus = bonus;
        _completedCount = 0;
    }
    
    public Checklist(string type, string name, string description, int points, int requiredTimes, int bonus, int completedCount, bool isCompleted) : base(type, name, description, points, isCompleted)
    {
        _requiredTimes = requiredTimes;
        _bonus = bonus;
        _completedCount = 0;
    }

    public override void Record(ref int totalPoints)
    {
    
        // int count = GET amount of times the user completed the goal 
        // _completedTimes += count
        int count = 0;
        _completedCount += count;

        // IF _completedCount >= _requireTimes
        //  totalPoints += (_points * count ) + bonus
        //  set isCompleted to true
        if (_completedCount >= _requiredTimes)
        {
            totalPoints += (_points * count) + _bonus;
            _isComplete = true;
        }
        
        //ELSE
        //  total += points * count
        else
        {
            totalPoints += _points * count;
        }

        // Display Message
        if (_isComplete)
        {
            Console.WriteLine($"Congratulations! You completed the goal and earned {totalPoints} points.");
        }
        
        else
        {
            Console.WriteLine($"You completed the goal {_completedCount} times and earned {totalPoints} points so far. Keep going!");
        }

        
    }
    
    // Getters
    public override int GetRequiredTimes()
    {
        return _requiredTimes;
    }
    public override int GetBonus()
    {
        return _bonus;
    }
    public override int GetCompletedCount()
    {
        return _completedCount;
    }
    
    public override void Display()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($" [X] | {_name} | {_description} | {_completedCount}/{_requiredTimes}");
        }

        else
        {
            Console.WriteLine($"[ ] | {_name} | {_description} | {_completedCount}/{_requiredTimes}");
        }
    }
}