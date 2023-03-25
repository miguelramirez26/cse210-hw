public class Game
{
    // Attributes
    private Board board;
    private Player player1;
    private Player player2;
    private Player currentPlayer;
    private GameResult gameResult;

    // Consutructors
    public Game(string Player1Name, string player2Name)
    {
        board = new Board();
        player1 = new Player(Player1Name);
        player2 = new Player(player2Name);
        currentPlayer = player1;
        gameResult.InProgress = true;
    }

    // Methods
    public void GameLoop()
    {
        while (gameResult.InProgress)
        {
            // Loop implementation
        }
    }
}