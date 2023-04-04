public class Director
{
    // Attributes
    private Board board;
    private Player player1;
    private Player player2;
    private GameData gameData;

    // Consutructors
    public Director(string Player1Name, string player2Name)
    {
        board = new Board();
        player1 = new Player(Player1Name, "X");
        player2 = new Player(player2Name, "O");
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