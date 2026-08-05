using System;
using System.Diagnostics;
using System.Threading.Tasks;

/// <summary>
/// Provides methods for sorting integer arrays using the Parallel Quick Sort algorithm.
/// </summary>
public class ParallelQuickSort
{
    // Minimum partition size for parallel execution.
    private const int THRESHOLD = 1000;

    /// <summary>
    /// Sorts the array in ascending order using Parallel Quick Sort.
    /// </summary>
    public static void Sort(int[] array)
    {
        ParallelQuickSortRecursive(array, 0, array.Length - 1);
    }

    /// <summary>
    /// Recursively sorts the array using Parallel Quick Sort.
    /// </summary>
    private static void ParallelQuickSortRecursive(int[] array, int low, int high)
    {
        // Continue sorting if the partition contains more than one element.
        if (low < high)
        {
            // Partition the array.
            int pivotIndex = Partition(array, low, high);

            // Use sequential recursion for small partitions.
            if (high - low < THRESHOLD)
            {
                ParallelQuickSortRecursive(array, low, pivotIndex - 1);
                ParallelQuickSortRecursive(array, pivotIndex + 1, high);
            }
            else
            {
                // Sort both partitions simultaneously.
                Parallel.Invoke(
                    () => ParallelQuickSortRecursive(array, low, pivotIndex - 1),
                    () => ParallelQuickSortRecursive(array, pivotIndex + 1, high)
                );
            }
        }
    }

    /// <summary>
    /// Partitions the array around the pivot element.
    /// </summary>
    private static int Partition(int[] array, int low, int high)
    {
        // Select the last element as the pivot.
        int pivot = array[high];

        // Index of the smaller element.
        int i = low - 1;

        // Compare each element with the pivot.
        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;

                // Swap elements.
                Swap(array, i, j);
            }
        }

        // Place the pivot into its correct position.
        Swap(array, i + 1, high);

        return i + 1;
    }

    /// <summary>
    /// Swaps two elements in the array.
    /// </summary>
    private static void Swap(int[] array, int firstIndex, int secondIndex)
    {
        int temp = array[firstIndex];
        array[firstIndex] = array[secondIndex];
        array[secondIndex] = temp;
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
/// Demonstrates the Parallel Quick Sort algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create an unsorted integer array.
        int[] numbers = { 15, 9, 3, 18, 7, 2, 11, 20, 5, 1 };

        Console.WriteLine("========== Parallel Quick Sort ==========\n");

        Console.WriteLine("Original Array:");
        ParallelQuickSort.PrintArray(numbers);

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        ParallelQuickSort.Sort(numbers);

        stopwatch.Stop();

        Console.WriteLine("\nSorted Array:");
        ParallelQuickSort.PrintArray(numbers);

        Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds:F6} ms");
    }
}