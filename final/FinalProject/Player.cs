using System;

public class Player
{
    // Attributes
    public string _name { get; }
    public string _marker { get; }

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
    }
}
