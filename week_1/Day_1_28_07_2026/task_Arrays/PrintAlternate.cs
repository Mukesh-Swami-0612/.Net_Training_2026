using System;

public class PrintAlternate
{
    public static void Alternate(int[] array)
    {
        Console.WriteLine("Alternate Elements:");

        for (int i = 0; i < array.Length; i += 2)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}