class Eternal : Goal
{
    public Eternal(string type, string name, string description, int points) : base(type, name, description, points)
    {

    }

    public override void Record(ref int totalPoints)
    {
        // Display message
        // Add points to totalPoints (totalPoints += _points)
        Console.WriteLine($"You have {totalPoints} points.");
        totalPoints += _points;
    }
}