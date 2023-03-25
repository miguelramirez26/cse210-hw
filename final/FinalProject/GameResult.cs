public class GameResult
{
    // Attributes
    public bool InProgress { get; set; }
    public int Tie { get; set; }
    public int Player1Wins { get; set; }
    public int Player2Wins { get; set; }

    // Methods
    public GameResult()
    {
        InProgress = true;
        Tie = 0;
        Player1Wins = 0;
        Player2Wins = 0;
    }
}