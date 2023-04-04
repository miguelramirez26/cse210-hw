public class Board 
{
    // Attributes
    private char[,] board = new char[3, 3]
    {
        {' ', ' ', ' '},
        {' ', ' ', ' '},
        {' ', ' ', ' '}
    };

    // Constructors
    public Board() {}

    // Methods
    public char[,] GetBoard() 
    {
        return board;
    }

    public void SetPiece(int row, int col, char piece) 
    {
        board[row, col] = piece;
    }

    public bool IsBoardFull() 
    {
        // iterate through each element in the 2d array
        //      check for whitespace char *if element == ' '*
        //          return false
        //          break    
        return true;
    }
}
