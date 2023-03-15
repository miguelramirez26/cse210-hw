class Simple : Goal
{
    // Add constructor without the isCompleted parameter
    public Simple(string type, string name, string description, int points) : base(type, name, description, points)
    {
        
    }

    public Simple(string type, string name, string description, int points, bool isComplete) : base(type, name, description,  points, isComplete)
    {
        
    }

    public override void Record(ref int totalPoints)
    {
        // Display message
        // Add points to totalPoints (totalPoints += _points)
        // Set isCompleted to true
        Console.WriteLine($"You earned {_points} points.");
        totalPoints += _points;
        _isComplete = true; 
        
    }
}