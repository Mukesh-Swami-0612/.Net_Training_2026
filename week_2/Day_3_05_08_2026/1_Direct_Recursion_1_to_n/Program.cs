using System;

/// <summary>
/// Demonstrates Direct Recursion.
/// A function directly calls itself until the base condition is met.
/// </summary>
class DirectRecursion
{
    /// <summary>
    /// Prints numbers from n to 1 using direct recursion.
    /// </summary>
    /// <param name="n">Starting number.</param>
    static void Display(int n)
    {
        // Base Case
        if (n == 0)
            return;

        // Print current number
        Console.WriteLine(n);

        // Recursive Call
        Display(n - 1);
    }

    /// <summary>
    /// Entry point of the program.
    /// </summary>
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nNumbers using Direct Recursion:");

        // Call recursive function
        Display(number);

        Console.ReadKey();
    }
}