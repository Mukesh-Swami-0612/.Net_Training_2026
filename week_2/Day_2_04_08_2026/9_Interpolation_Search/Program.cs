using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for searching an element using the Interpolation Search algorithm.
/// </summary>
public class InterpolationSearch
{
    /// <summary>
    /// Searches for the specified element in the sorted array.
    /// </summary>
    public static int Search(int[] array, int target)
    {
        // Initialize the starting index.
        int low = 0;

        // Initialize the ending index.
        int high = array.Length - 1;

        // Continue searching while the target lies within the current range.
        while (low <= high &&
               target >= array[low] &&
               target <= array[high])
        {
            // Check whether only one element remains.
            if (low == high)
            {
                if (array[low] == target)
                {
                    return low;
                }

                return -1;
            }

            // Estimate the probable position of the target element.
            int position = low +
                ((target - array[low]) * (high - low))
                / (array[high] - array[low]);

            // Check whether the estimated position contains the target.
            if (array[position] == target)
            {
                // Return the index where the element is found.
                return position;
            }

            // Check whether the target is greater than the estimated element.
            if (array[position] < target)
            {
                // Search in the right portion.
                low = position + 1;
            }
            else
            {
                // Search in the left portion.
                high = position - 1;
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
/// Demonstrates the Interpolation Search algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create a sorted integer array.
        int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        // Element to search.
        int target = 70;

        Console.WriteLine("Interpolation Search");

        Console.WriteLine("Sorted Array:");
        InterpolationSearch.PrintArray(numbers);

        Console.WriteLine($"\nElement to Search: {target}");

        // Create a Stopwatch object.
        Stopwatch stopwatch = new Stopwatch();

        // Start measuring execution time.
        stopwatch.Start();

        // Search the element.
        int result = InterpolationSearch.Search(numbers, target);

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