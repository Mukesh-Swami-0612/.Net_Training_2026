using System;

class Program
{
    // Tree recursive method to count paths
    static int CountPaths(int rows, int cols)
    {
        // Base case:
        // If there is only one row or one column,
        // there is only one possible path.
        if (rows == 1 || cols == 1)
            return 1;

        // Tree recursion:
        // Move down OR move right
        return CountPaths(rows - 1, cols)
             + CountPaths(rows, cols - 1);
    }

    static void Main(string[] args)
    {
        int rows = 3;
        int cols = 3;

        int result = CountPaths(rows, cols);

        Console.WriteLine("Grid: " + rows + " x " + cols);
        Console.WriteLine("Number of paths: " + result);
    }
}