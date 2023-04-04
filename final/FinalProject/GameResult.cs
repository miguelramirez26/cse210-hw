public class GameData
{
    // Attributes
    protected bool InProgress { get; set; }
    protected int Tie { get; set; }
    protected int Player1Wins { get; set; }
    protected int Player2Wins { get; set; }

    // attribute track turn, track game number.
    protected 
    
    // Methods
    public GameData()
    {
        InProgress = true;
        Tie = 0;
        Player1Wins = 0;
        Player2Wins = 0;
    }

    // method to check for if a player has three in a row
    // loop for each X and O. i = *current player symbol*
    //      check the current board against ass 8 possible win condisiton
    //      current board == 
    // board = new char[3, 3]
    // {
    //     {'{i}', ' ', ' '},
    //     {' ', '{i}', ' '},
    //     {' ', ' ', '{i}'}
    // };

    public bool CheckThreeInARow(char[,] board, char piece)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // Check rows
                if (board[i, 0] == piece && board[i, 1] == piece && board[i, 2] == piece)
                {
                    return true;
                }
                // Check columns
                else if (board[0, j] == piece && board[1, j] == piece && board[2, j] == piece)
                {
                    return true;
                }
            }
        }
        // Check diagonals
        if (board[0, 0] == piece && board[1, 1] == piece && board[2, 2] == piece)
        {
            return true;
        }
        else if (board[0, 2] == piece && board[1, 1] == piece && board[2, 0] == piece)
        {
            return true;
        }
        // No three in a row found
        return false;
    }
}