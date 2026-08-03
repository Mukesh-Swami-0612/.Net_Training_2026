using System;
using System.Diagnostics;

public class QuickSort
{

    public static void Sort(int[] array)
    {
  
        if (array.Length > 1)
        {
            QuickSortRecursive(array, 0, array.Length - 1);
        }
    }


    private static void QuickSortRecursive(int[] array, int low, int high)
    {
        
        if (low < high)
        {
            
            int pivotIndex = Partition(array, low, high);

            
            QuickSortRecursive(array, low, pivotIndex - 1);

            
            QuickSortRecursive(array, pivotIndex + 1, high);
        }
    }


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

 
    private static void Swap(int[] array, int firstIndex, int secondIndex)
    {
        
        int temp = array[firstIndex];

        
        array[firstIndex] = array[secondIndex];

        
        array[secondIndex] = temp;
    }

   
    public static void PrintArray(int[] array)
    {
        
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}


public class Program
{
   
 
    public static void Main(string[] args)
    {
        
        int[] numbers = { 10, 7, 8, 9, 1, 5 };

        Console.WriteLine("Quick Sort \n");

        Console.WriteLine("Original Array:");
        QuickSort.PrintArray(numbers);

        
        Stopwatch stopwatch = new Stopwatch();

        
        stopwatch.Start();

        
        QuickSort.Sort(numbers);

        
        stopwatch.Stop();

        Console.WriteLine("\nSorted Array:");
        QuickSort.PrintArray(numbers);
    }
}