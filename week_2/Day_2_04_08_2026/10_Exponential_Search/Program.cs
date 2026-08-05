using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for searching an element using the Exponential Search algorithm.
/// </summary>
public class ExponentialSearch
{
    /// <summary>
    /// Searches for the specified element in the sorted array.
    /// </summary>
    public static int Search(int[] array, int target)
    {
        // Check whether the first element is the target.
        if (array[0] == target)
        {
            return 0;
        }

        // Initialize the search range.
        int index = 1;

        // Increase the search range exponentially.
        while (index < array.Length && array[index] <= target)
        {
            index *= 2;
        }

        // Perform Binary Search within the identified range.
        return BinarySearch(
            array,
            target,
            index / 2,
            Math.Min(index, array.Length - 1)
        );
    }

    /// <summary>
    /// Searches for the element within the specified range using Binary Search.
    /// </summary>
    private static int BinarySearch(int[] array, int target, int left, int right)
    {
        // Continue searching while the search range is valid.
        while (left <= right)
        {
            // Calculate the middle index.
            int middle = left + (right - left) / 2;

            // Check whether the middle element is the target.
            if (array[middle] == target)
            {
                return middle;
            }

            // Check whether the target is smaller than the middle element.
            if (target < array[middle])
            {
                // Search the left half.
                right = middle - 1;
            }
            else
            {
                // Search the right half.
                left = middle + 1;
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
/// Demonstrates the Exponential Search algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create a sorted integer array.
        int[] numbers = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 72, 91, 100 };

        // Element to search.
        int target = 56;

        Console.WriteLine("========== Exponential Search ==========\n");

        Console.WriteLine("Sorted Array:");
        ExponentialSearch.PrintArray(numbers);

        Console.WriteLine($"\nElement to Search: {target}");

        // Create a Stopwatch object.
        Stopwatch stopwatch = new Stopwatch();

        // Start measuring execution time.
        stopwatch.Start();

        // Search the element.
        int result = ExponentialSearch.Search(numbers, target);

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