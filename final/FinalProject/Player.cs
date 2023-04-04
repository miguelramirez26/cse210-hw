using System;

public class Player
{
    // Attributes
    protected string _name { get; }
    protected string _marker { get; }

    // Constructors
    public Player(string name, string marker)
    {
        _name = name;
        _marker = marker;
    }

    // Methods
    public virtual int GetMove(Board board)
    {
        // Method implementation
        return 0;
    }
}
