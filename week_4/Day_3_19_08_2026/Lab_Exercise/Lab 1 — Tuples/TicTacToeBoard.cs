using System;
using System.Collections.Generic;

namespace Lab1Tuples
{
    // Summary:
    // Represents a Tic-Tac-Toe board using a Dictionary with
    // (Row, Col) tuple keys and string values.
    public class TicTacToeBoard
    {
        // Dictionary where:
        // Key   = (Row, Col)
        // Value = Player symbol such as X or O.
        private readonly Dictionary<(int Row, int Col), string> board;

        // Summary:
        // Creates an empty Tic-Tac-Toe board.
        public TicTacToeBoard()
        {
            // Initialize the dictionary.
            board = new Dictionary<(int Row, int Col), string>();
        }

        // Summary:
        // Places a player's symbol at the specified row and column.
        public void SetCell(int row, int col, string value)
        {
            // Store the value using the tuple as the dictionary key.
            board[(row, col)] = value;
        }

        // Summary:
        // Prints the complete 3x3 Tic-Tac-Toe board.
        // Empty cells are displayed as "-".
        public void PrintBoard()
        {
            // Loop through each row.
            for (int row = 0; row < 3; row++)
            {
                // Loop through each column.
                for (int col = 0; col < 3; col++)
                {
                    // Create the tuple key.
                    var position = (row, col);

                    // Try to find the cell in the dictionary.
                    // If it does not exist, display "-".
                    if (board.TryGetValue(position, out string? value))
                    {
                        Console.Write(value);
                    }
                    else
                    {
                        Console.Write("-");
                    }

                    // Add spacing between cells.
                    Console.Write(" ");
                }

                // Move to the next line after each row.
                Console.WriteLine();
            }
        }
    }
}