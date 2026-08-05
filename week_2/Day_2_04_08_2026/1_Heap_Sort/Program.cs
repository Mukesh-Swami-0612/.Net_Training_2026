using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for sorting integer arrays using the Heap Sort algorithm.
/// </summary>
public class HeapSort
{
    /// <summary>
    /// Sorts the array in ascending order using Heap Sort.
    /// </summary>
    public static void Sort(int[] array)
    {
        int length = array.Length;

        // Build a Max Heap.
        for (int i = length / 2 - 1; i >= 0; i--)
        {
            Heapify(array, length, i);
        }

        // Extract the largest element one by one.
        for (int i = length - 1; i > 0; i--)
        {
            // Move the root (largest element) to the end.
            Swap(array, 0, i);

            // Restore the heap property for the reduced heap.
            Heapify(array, i, 0);
        }
    }

    /// <summary>
    /// Converts a subtree into a Max Heap.
    /// </summary>
    private static void Heapify(int[] array, int heapSize, int rootIndex)
    {
        // Assume the root is the largest.
        int largest = rootIndex;

        // Calculate left and right child indexes.
        int leftChild = 2 * rootIndex + 1;
        int rightChild = 2 * rootIndex + 2;

        // Check whether the left child is larger than the root.
        if (leftChild < heapSize && array[leftChild] > array[largest])
        {
            largest = leftChild;
        }

        // Check whether the right child is larger than the current largest.
        if (rightChild < heapSize && array[rightChild] > array[largest])
        {
            largest = rightChild;
        }

        // If the largest element is not the root, swap them.
        if (largest != rootIndex)
        {
            Swap(array, rootIndex, largest);

            // Heapify the affected subtree.
            Heapify(array, heapSize, largest);
        }
    }

    /// <summary>
    /// Swaps two elements in the array.
    /// </summary>
    private static void Swap(int[] array, int firstIndex, int secondIndex)
    {
        // Store the first element temporarily.
        int temp = array[firstIndex];

        // Move the second element to the first position.
        array[firstIndex] = array[secondIndex];

        // Place the original first element into the second position.
        array[secondIndex] = temp;
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
/// Demonstrates the Heap Sort algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create an unsorted integer array.
        int[] numbers = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("========== Heap Sort ==========\n");

        Console.WriteLine("Original Array:");
        HeapSort.PrintArray(numbers);

        // Create a Stopwatch object.
        Stopwatch stopwatch = new Stopwatch();

        // Start measuring execution time.
        stopwatch.Start();

        // Sort the array using Heap Sort.
        HeapSort.Sort(numbers);

        // Stop measuring execution time.
        stopwatch.Stop();

        Console.WriteLine("\nSorted Array:");
        HeapSort.PrintArray(numbers);

        // Display the execution time.
        Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds:F6} ms");
    }
}