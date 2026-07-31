using System;

public class PrintArray
{
    public static void Print(int[] array)
    {
        Console.WriteLine("Array Elements:");

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}