using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for searching an element using the Binary Search algorithm.
/// </summary>
public class BinarySearch
{
    /// <summary>
    /// Searches for the specified element in the sorted array.
    /// </summary>
    public static int Search(int[] array, int target)
    {
        // Initialize the starting index.
        int left = 0;

        // Initialize the ending index.
        int right = array.Length - 1;

        // Continue searching until the search range becomes invalid.
        while (left <= right)
        {
            // Calculate the middle index.
            int middle = left + (right - left) / 2;

            // Check whether the middle element matches the target.
            if (array[middle] == target)
            {
                // Return the index where the element is found.
                return middle;
            }

            // Check whether the target is smaller than the middle element.
            if (target < array[middle])
            {
                // Search in the left half.
                right = middle - 1;
            }
            else
            {
                // Search in the right half.
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
/// Demonstrates the Binary Search algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create a sorted integer array.
        int[] numbers = { 5, 8, 12, 15, 18, 25, 30, 35, 40 };

        // Element to search.
        int target = 25;

        Console.WriteLine("Binary Search");

        Console.WriteLine("Sorted Array:");
        BinarySearch.PrintArray(numbers);

        Console.WriteLine($"\nElement to Search: {target}");

        // Create a Stopwatch object.
        Stopwatch stopwatch = new Stopwatch();

        // Start measuring execution time.
        stopwatch.Start();

        // Search the element.
        int result = BinarySearch.Search(numbers, target);

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