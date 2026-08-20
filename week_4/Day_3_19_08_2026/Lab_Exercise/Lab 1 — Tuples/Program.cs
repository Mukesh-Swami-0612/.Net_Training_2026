using System;

namespace Lab1Tuples
{
    // Summary:
    // Entry point of the application.
    // Demonstrates all four tuple examples from the lab.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the title.
            Console.WriteLine("=================================");
            Console.WriteLine("        LAB 1 - TUPLES");
            Console.WriteLine("=================================");

            // ---------------------------------------------------------
            // PART 1 & 2 - Get Statistics and Tuple Deconstruction
            // ---------------------------------------------------------

            Console.WriteLine("\n1. Statistics using ValueTuple");

            double[] values = { 70, 80, 85, 90, 95 };

            // Call GetStats() and deconstruct the returned tuple.
            var (avg, min, max) = StatisticsService.GetStats(values);

            // Print the individual values.
            Console.WriteLine($"Average: {avg:F2}");
            Console.WriteLine($"Minimum: {min:F2}");
            Console.WriteLine($"Maximum: {max:F2}");

            // ---------------------------------------------------------
            // PART 3 - TryParseAge
            // ---------------------------------------------------------

            Console.WriteLine("\n2. TryParseAge()");

            // Test a valid age.
            var validResult = AgeParser.TryParseAge("25");

            Console.WriteLine($"Input: 25");
            Console.WriteLine($"Success: {validResult.Success}");
            Console.WriteLine($"Error Message: {validResult.ErrorMessage ?? "None"}");

            // Test an invalid age.
            var invalidResult = AgeParser.TryParseAge("abc");

            Console.WriteLine("\nInput: abc");
            Console.WriteLine($"Success: {invalidResult.Success}");
            Console.WriteLine($"Error Message: {invalidResult.ErrorMessage ?? "None"}");

            // ---------------------------------------------------------
            // PART 4 - Tic-Tac-Toe Dictionary
            // ---------------------------------------------------------

            Console.WriteLine("\n3. Tic-Tac-Toe Board");

            // Create the board.
            var board = new TicTacToeBoard();

            // Populate a few cells.
            board.SetCell(0, 0, "X");
            board.SetCell(0, 1, "O");
            board.SetCell(1, 1, "X");
            board.SetCell(2, 0, "O");
            board.SetCell(2, 2, "X");

            // Print the board.
            board.PrintBoard();

            // ---------------------------------------------------------
            // END
            // ---------------------------------------------------------

            Console.WriteLine("\n=================================");
            Console.WriteLine("       DEMONSTRATION COMPLETE");
            Console.WriteLine("=================================");
        }
    }
}