using System;
using System.Diagnostics;

public class MergeSort
{
    /// <summary>
    /// Sorts the array in ascending order using Merge Sort.
    /// </summary>
    public static void Sort(int[] array)
    {
        // Check if the array has more than one element.
        if (array.Length > 1)
        {
            MergeSortRecursive(array, 0, array.Length - 1);
        }
    }

    /// <summary>
    /// Recursively divides the array into smaller subarrays.
    /// </summary>
    private static void MergeSortRecursive(int[] array, int left, int right)
    {
        // Continue dividing until a single element remains.
        if (left < right)
        {
            // Find the middle index.
            int middle = left + (right - left) / 2;

            // Sort the left half.
            MergeSortRecursive(array, left, middle);

            // Sort the right half.
            MergeSortRecursive(array, middle + 1, right);

            // Merge the sorted halves.
            Merge(array, left, middle, right);
        }
    }

    /// <summary>
    /// Merges two sorted subarrays into one sorted array.
    /// </summary>
    private static void Merge(int[] array, int left, int middle, int right)
    {
        // Calculate the sizes of the two subarrays.
        int leftSize = middle - left + 1;
        int rightSize = right - middle;

        // Create temporary arrays.
        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        // Copy data into the left temporary array.
        for (int i = 0; i < leftSize; i++)
        {
            leftArray[i] = array[left + i];
        }

        // Copy data into the right temporary array.
        for (int j = 0; j < rightSize; j++)
        {
            rightArray[j] = array[middle + 1 + j];
        }

        // Initialize indexes.
        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = left;

        // Merge the temporary arrays back into the original array.
        while (leftIndex < leftSize && rightIndex < rightSize)
      {
            if (leftArray[leftIndex] <= rightArray[rightIndex])
            {
                array[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                array[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
            }

            mergedIndex++;
        }

        // Copy any remaining elements from the left array.
        while (leftIndex < leftSize)
        {
            array[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        // Copy any remaining elements from the right array.
        while (rightIndex < rightSize)
        {
            array[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
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
/// Demonstrates the Merge Sort algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create an unsorted integer array.
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine("Merge Sort\n");

        Console.WriteLine("Original Array:");
        MergeSort.PrintArray(numbers);

        // Create a Stopwatch object.
        Stopwatch stopwatch = new Stopwatch();

        // Start measuring execution time.
        stopwatch.Start();

        // Sort the array using Merge Sort.
        MergeSort.Sort(numbers);

        // Stop measuring execution time.
        stopwatch.Stop();

        Console.WriteLine("\nSorted Array:");
        MergeSort.PrintArray(numbers);

        // Display the execution time in milliseconds.
        Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds:F6} ms");
    }
}