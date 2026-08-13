public class Matrix
{
    private readonly int[,] _cells;

    public Matrix(int rows, int cols)
    {
        _cells = new int[rows, cols];
    }

    public int this[int row, int col]
    {
        get
        {
            return _cells[row, col];
        }
        set
        {
            _cells[row, col] = value;
        }
    }
}