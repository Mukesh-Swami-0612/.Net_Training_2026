using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for searching an element using the Linear Search algorithm.
/// </summary>
public class LinearSearch
{
    /// <summary>
    /// Searches for the specified element in the array.
    /// </summary>
    public static int Search(int[] array, int target)
    {
        // Traverse each element of the array.
        for (int index = 0; index < array.Length; index++)
        {
            // Check whether the current element matches the target.
            if (array[index] == target)
            {
                // Return the index where the element is found.
                return index;
            }
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
/// Demonstrates the Linear Search algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create an integer array.
        int[] numbers = { 15, 8, 25, 12, 30, 18, 10 };

        // Element to search.
        int target = 18;

        Console.WriteLine("Linear Search");

        Console.WriteLine("Array Elements:");
        LinearSearch.PrintArray(numbers);

        Console.WriteLine($"\nElement to Search: {target}");

        // Create a Stopwatch object.
        Stopwatch stopwatch = new Stopwatch();

        // Start measuring execution time.
        stopwatch.Start();

        // Search the element.
        int result = LinearSearch.Search(numbers, target);

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