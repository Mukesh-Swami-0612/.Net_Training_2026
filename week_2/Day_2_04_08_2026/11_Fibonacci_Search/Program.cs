using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for searching an element using the Fibonacci Search algorithm.
/// </summary>
public class FibonacciSearch
{
    /// <summary>
    /// Searches for the specified element in the sorted array.
    /// </summary>
    public static int Search(int[] array, int target)
    {
        // Initialize Fibonacci numbers.
        int fibonacciSecond = 0;
        int fibonacciFirst = 1;
        int fibonacci = fibonacciFirst + fibonacciSecond;

        // Find the smallest Fibonacci number greater than or equal to the array length.
        while (fibonacci < array.Length)
        {
            fibonacciSecond = fibonacciFirst;
            fibonacciFirst = fibonacci;
            fibonacci = fibonacciFirst + fibonacciSecond;
        }

        // Marks the eliminated range from the front.
        int offset = -1;

        // Continue searching while Fibonacci number is greater than one.
        while (fibonacci > 1)
        {
            // Calculate the index to be compared.
            int index = Math.Min(offset + fibonacciSecond, array.Length - 1);

            // Check whether the target is greater than the current element.
            if (array[index] < target)
            {
                fibonacci = fibonacciFirst;
                fibonacciFirst = fibonacciSecond;
                fibonacciSecond = fibonacci - fibonacciFirst;
                offset = index;
            }
            // Check whether the target is smaller than the current element.
            else if (array[index] > target)
            {
                fibonacci = fibonacciSecond;
                fibonacciFirst = fibonacciFirst - fibonacciSecond;
                fibonacciSecond = fibonacci - fibonacciFirst;
            }
            else
            {
                // Return the index where the element is found.
                return index;
            }
        }

        // Check the last possible element.
        if (fibonacciFirst == 1 &&
            offset + 1 < array.Length &&
            array[offset + 1] == target)
        {
            return offset + 1;
        }

        // Return -1 if the element is not found.
        return -1;
    }

    /// <summary>
    /// Displays the elements of the array.
    /// </summary>
    public static void PrintArray(int[] array)
    {
        // Print each element separated by spaces.
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}

/// <summary>
/// Entry point of the application.
/// Demonstrates the Fibonacci Search algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create a sorted integer array.
        int[] numbers = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

        // Element to search.
        int target = 35;

        Console.WriteLine("========== Fibonacci Search ==========\n");

        Console.WriteLine("Sorted Array:");
        FibonacciSearch.PrintArray(numbers);

        Console.WriteLine($"\nElement to Search: {target}");

        // Create a Stopwatch object.
        Stopwatch stopwatch = new Stopwatch();

        // Start measuring execution time.
        stopwatch.Start();

        // Search the element.
        int result = FibonacciSearch.Search(numbers, target);

        // Stop measuring execution time.
        stopwatch.Stop();

        // Display the search result.
        if (result != -1)
        {
            Console.WriteLine($"\nElement found at index: {result}");
        }
        else
        {
            Console.WriteLine("\nElement not found.");
        }

        // Display the execution time in milliseconds.
        Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds:F6} ms");
    }
}