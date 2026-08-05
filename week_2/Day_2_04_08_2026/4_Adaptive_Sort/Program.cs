using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for sorting integer arrays using an Adaptive Insertion Sort algorithm.
/// </summary>
public class AdaptiveSort
{
    /// <summary>
    /// Sorts the array in ascending order.
    /// </summary>
    public static void Sort(int[] array)
    {
        // Traverse the array starting from the second element.
        for (int i = 1; i < array.Length; i++)
        {
            // Store the current element.
            int key = array[i];

            // Initialize the previous index.
            int j = i - 1;

            // Shift larger elements to the right.
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            // Insert the current element into its correct position.
            array[j + 1] = key;
        }
    }

    /// <summary>
    /// Displays the elements of the array.
    /// </summary>
    public static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}

/// <summary>
/// Entry point of the application.
/// Demonstrates Adaptive Sort.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create a nearly sorted array.
        int[] numbers = { 10, 20, 30, 25, 40, 50 };

        Console.WriteLine("Adaptive Sort \n");

        Console.WriteLine("Original Array:");
        AdaptiveSort.PrintArray(numbers);

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        AdaptiveSort.Sort(numbers);

        stopwatch.Stop();

        Console.WriteLine("\nSorted Array:");
        AdaptiveSort.PrintArray(numbers);

        Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds:F6} ms");
    }
}