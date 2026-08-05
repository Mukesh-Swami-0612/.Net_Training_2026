using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for sorting integer arrays using the Tim Sort algorithm.
/// </summary>
public class TimSort
{
    // Minimum size of a run.
    private const int RUN = 32;

    /// <summary>
    /// Sorts the array in ascending order using Tim Sort.
    /// </summary>
    public static void Sort(int[] array)
    {
        int length = array.Length;

        // Sort small runs using Insertion Sort.
        for (int i = 0; i < length; i += RUN)
        {
            InsertionSort(array, i, Math.Min(i + RUN - 1, length - 1));
        }

        // Merge sorted runs.
        for (int size = RUN; size < length; size *= 2)
        {
            for (int left = 0; left < length; left += 2 * size)
            {
                int middle = Math.Min(left + size - 1, length - 1);
                int right = Math.Min(left + 2 * size - 1, length - 1);

                if (middle < right)
                {
                    Merge(array, left, middle, right);
                }
            }
        }
    }

    /// <summary>
    /// Sorts a portion of the array using Insertion Sort.
    /// </summary>
    private static void InsertionSort(int[] array, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= left && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }

    /// <summary>
    /// Merges two sorted subarrays.
    /// </summary>
    private static void Merge(int[] array, int left, int middle, int right)
    {
        int leftSize = middle - left + 1;
        int rightSize = right - middle;

        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        for (int i = 0; i < leftSize; i++)
            leftArray[i] = array[left + i];

        for (int j = 0; j < rightSize; j++)
            rightArray[j] = array[middle + 1 + j];

        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = left;

        while (leftIndex < leftSize && rightIndex < rightSize)
        {
            if (leftArray[leftIndex] <= rightArray[rightIndex])
            {
                array[mergedIndex++] = leftArray[leftIndex++];
            }
            else
            {
                array[mergedIndex++] = rightArray[rightIndex++];
            }
        }

        while (leftIndex < leftSize)
        {
            array[mergedIndex++] = leftArray[leftIndex++];
        }

        while (rightIndex < rightSize)
        {
            array[mergedIndex++] = rightArray[rightIndex++];
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
/// Demonstrates the Tim Sort algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        int[] numbers = { 5, 21, 7, 23, 19, 10, 2, 45, 12, 8 };

        Console.WriteLine("========== Tim Sort ==========\n");

        Console.WriteLine("Original Array:");
        TimSort.PrintArray(numbers);

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        TimSort.Sort(numbers);

        stopwatch.Stop();

        Console.WriteLine("\nSorted Array:");
        TimSort.PrintArray(numbers);

        Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds:F6} ms");
    }
}