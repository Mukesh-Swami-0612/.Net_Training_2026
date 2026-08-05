using System;
using System.Diagnostics;

/// <summary>
/// Provides methods for sorting integer arrays using the Introspective Sort algorithm.
/// </summary>
public class IntroSort
{
    // Threshold for switching to Insertion Sort.
    private const int INSERTION_SORT_THRESHOLD = 16;

    /// <summary>
    /// Sorts the array in ascending order using Introspective Sort.
    /// </summary>
    public static void Sort(int[] array)
    {
        if (array.Length <= 1)
            return;

        // Calculate the maximum recursion depth.
        int depthLimit = 2 * (int)Math.Log2(array.Length);

        IntroSortRecursive(array, 0, array.Length - 1, depthLimit);
    }

    /// <summary>
    /// Recursively sorts the array using Introspective Sort.
    /// </summary>
    private static void IntroSortRecursive(int[] array, int low, int high, int depthLimit)
    {
        int size = high - low + 1;

        // Use Insertion Sort for small partitions.
        if (size <= INSERTION_SORT_THRESHOLD)
        {
            InsertionSort(array, low, high);
            return;
        }

        // Switch to Heap Sort if recursion depth is exceeded.
        if (depthLimit == 0)
        {
            HeapSort(array, low, high);
            return;
        }

        // Partition using Quick Sort.
        int pivot = Partition(array, low, high);

        IntroSortRecursive(array, low, pivot - 1, depthLimit - 1);
        IntroSortRecursive(array, pivot + 1, high, depthLimit - 1);
    }

    /// <summary>
    /// Partitions the array around a pivot.
    /// </summary>
    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);

        return i + 1;
    }

    /// <summary>
    /// Sorts a small partition using Insertion Sort.
    /// </summary>
    private static void InsertionSort(int[] array, int low, int high)
    {
        for (int i = low + 1; i <= high; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= low && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }

    /// <summary>
    /// Sorts a partition using Heap Sort.
    /// </summary>
    private static void HeapSort(int[] array, int low, int high)
    {
        int size = high - low + 1;

        for (int i = size / 2 - 1; i >= 0; i--)
        {
            Heapify(array, size, i, low);
        }

        for (int i = size - 1; i > 0; i--)
        {
            Swap(array, low, low + i);
            Heapify(array, i, 0, low);
        }
    }

    /// <summary>
    /// Restores the Max Heap property.
    /// </summary>
    private static void Heapify(int[] array, int heapSize, int root, int offset)
    {
        int largest = root;
        int left = 2 * root + 1;
        int right = 2 * root + 2;

        if (left < heapSize &&
            array[offset + left] > array[offset + largest])
        {
            largest = left;
        }

        if (right < heapSize &&
            array[offset + right] > array[offset + largest])
        {
            largest = right;
        }

        if (largest != root)
        {
            Swap(array, offset + root, offset + largest);
            Heapify(array, heapSize, largest, offset);
        }
    }

    /// <summary>
    /// Swaps two elements.
    /// </summary>
    private static void Swap(int[] array, int first, int second)
    {
        int temp = array[first];
        array[first] = array[second];
        array[second] = temp;
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
/// Demonstrates the Introspective Sort algorithm.
/// </summary>
public class Program
{
    /// <summary>
    /// Main method of the application.
    /// </summary>
    public static void Main(string[] args)
    {
        int[] numbers = { 12, 4, 7, 3, 9, 15, 1, 20, 6 };

        Console.WriteLine("========== Introspective Sort ==========\n");

        Console.WriteLine("Original Array:");
        IntroSort.PrintArray(numbers);

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();

        IntroSort.Sort(numbers);

        stopwatch.Stop();

        Console.WriteLine("\nSorted Array:");
        IntroSort.PrintArray(numbers);

        Console.WriteLine($"\nExecution Time: {stopwatch.Elapsed.TotalMilliseconds:F6} ms");
    }
}