using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for searching an element using the Jump Search algorithm.
/// </summary>
public class JumpSearch
{
    /// <summary>
    /// Searches for the specified element in the sorted array.
    /// </summary>
    public static int Search(int[] array, int target)
    {
        // Calculate the jump size.
        int step = (int)Math.Sqrt(array.Length);

        // Initialize the previous block index.
        int previous = 0;

        // Find the block where the target element may exist.
        while (previous < array.Length &&
               array[Math.Min(step, array.Length) - 1] < target)
        {
            // Move to the next block.
            previous = step;

            // Increase the jump size to the next block.
            step += (int)Math.Sqrt(array.Length);

            // Check whether the search has reached the end of the array.
            if (previous >= array.Length)
            {
                return -1;
            }
        }

        // Perform a linear search within the identified block.
        while (previous < Math.Min(step, array.Length))
        {
            // Check whether the current element matches the target.
            if (array[previous] == target)
            {
                // Return the index where the element is found.
                return previous;
            }

            // Move to the next element.
            previous++;
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
/// Demonstrates the Jump Search algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create a sorted integer array.
        int[] numbers = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 72, 91 };

        // Element to search.
        int target = 38;

        Console.WriteLine("Jump Search");

        Console.WriteLine("Sorted Array:");
        JumpSearch.PrintArray(numbers);

        Console.WriteLine($"\nElement to Search: {target}");

        // Create a Stopwatch object.
        Stopwatch stopwatch = new Stopwatch();

        // Start measuring execution time.
        stopwatch.Start();

        // Search the element.
        int result = JumpSearch.Search(numbers, target);

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