using System;

public class MergeArrays
{
    public static void Merge(int[] array1, int[] array2)
    {
        int[] merged = new int[array1.Length + array2.Length];

        int index = 0;

        foreach (int num in array1)
        {
            merged[index] = num;
            index++;
        }

        foreach (int num in array2)
        {
            merged[index] = num;
            index++;
        }

        Console.WriteLine("Merged Array:");

        foreach (int num in merged)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}