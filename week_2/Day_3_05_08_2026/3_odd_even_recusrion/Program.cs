using System;

/// <summary>
/// Demonstrates printing Odd and Even numbers using Recursion.
/// </summary>
class OddEvenRecursion
{
    /// <summary>
    /// Prints all even numbers from 1 to n using recursion.
    /// </summary>
    /// <param name="n">Upper limit.</param>
    static void PrintEven(int n)
    {
        // Base Case
        if (n == 0)
            return;

        // Recursive Call
        PrintEven(n - 1);

        // Print if number is even
        if (n % 2 == 0)
        {
            Console.Write(n + " ");
        }
    }

    /// <summary>
    /// Prints all odd numbers from 1 to n using recursion.
    /// </summary>
    /// <param name="n">Upper limit.</param>
    static void PrintOdd(int n)
    {
        // Base Case
        if (n == 0)
            return;

        // Recursive Call
        PrintOdd(n - 1);

        // Print if number is odd
        if (n % 2 != 0)
        {
            Console.Write(n + " ");
        }
    }

    /// <summary>
    /// Entry point of the program.
    /// </summary>
    static void Main()
    {
        // Read limit from the user
        Console.Write("Enter the limit: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Print even numbers
        Console.WriteLine("\nEven Numbers:");
        PrintEven(n);

        // Print odd numbers
        Console.WriteLine("\n\nOdd Numbers:");
        PrintOdd(n);

        Console.ReadKey();
    }
}