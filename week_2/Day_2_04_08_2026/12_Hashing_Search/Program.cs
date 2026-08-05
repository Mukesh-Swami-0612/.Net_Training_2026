using System;
using System.Collections.Generic;
using System.Diagnostics;

/// <summary>
/// Provides methods for searching an element using the Hashing Search algorithm.
/// </summary>
public class HashingSearch
{
    /// <summary>
    /// Searches for the specified element using a Hash Table.
    /// </summary>
    public static bool Search(int[] array, int target)
    {
        // Create a Hash Table.
        Dictionary<int, bool> hashTable = new Dictionary<int, bool>();

        // Insert every element into the Hash Table.
        foreach (int number in array)
        {
            // Add the element only if it does not already exist.
            if (!hashTable.ContainsKey(number))
            {
                hashTable.Add(number, true);
            }
        }

        // Check whether the target exists in the Hash Table.
        return hashTable.ContainsKey(target);
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
/// Demonstrates the Hashing Search algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create an integer array.
        int[] numbers = { 25, 10, 35, 20, 45, 15, 30 };

        // Element to search.
        int target = 20;

        Console.WriteLine("========== Hashing Search ==========\n");

        Console.WriteLine("Array Elements:");
        HashingSearch.PrintArray(numbers);

        Console.WriteLine($"\nElement to Search: {target}");

        // Create a Stopwatch object.
        Stopwatch stopwatch = new Stopwatch();

        // Start measuring execution time.
        stopwatch.Start();

        // Search the element.
        bool found = HashingSearch.Search(numbers, target);

        // Stop measuring execution time.
        stopwatch.Stop();

        // Display the search result.
        if (found)
        {
            Console.WriteLine("\nElement found.");
        }
        else
        {
            Console.WriteLine("\nElement not found.");
        }

        // Display the execution time in milliseconds.
        Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds:F6} ms");
    }
}