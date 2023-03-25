public class Board 
{
    // Attributes
    private string[,] pieces;
    private int numRows;
    private int numCols;

    // Constructors
    public Board(int numRows, int numCols) {
        this.numRows = numRows;
        this.numCols = numCols;
        this.pieces = new string[numRows, numCols];
    }

    // Methods
    public string GetPiece(int row, int col) 
    {
        return pieces[row, col];
    }

    public void SetPiece(int row, int col, string piece) 
    {
        pieces[row, col] = piece;
    }

    public bool IsBoardFull() 
    {
        return true;
    }

    public bool IsGameOver() 
    {
        return false;
    }
}
