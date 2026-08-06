using System;

/// <summary>
/// Demonstrates Indirect Recursion.
/// One function calls another function,
/// which again calls the first function.
/// </summary>
class IndirectRecursion
{
    /// <summary>
    /// Prints value and calls FunctionB.
    /// </summary>
    /// <param name="n">Current number.</param>
    static void FunctionA(int n)
    {
        // Base Case
        if (n <= 0)
            return;

        Console.WriteLine("Function A : " + n);

        // Call another function
        FunctionB(n - 1);
    }

    /// <summary>
    /// Prints value and calls FunctionA.
    /// </summary>
    /// <param name="n">Current number.</param>
    static void FunctionB(int n)
    {
        // Base Case
        if (n <= 0)
            return;

        Console.WriteLine("Function B : " + n);

        // Call first function again
        FunctionA(n - 1);
    }

    /// <summary>
    /// Entry point of the program.
    /// </summary>
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIndirect Recursion:");

        // Start recursion
        FunctionA(number);

        Console.ReadKey();
    }
}