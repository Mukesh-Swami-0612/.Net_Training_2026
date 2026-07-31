using System;

public class ReverseArray
{
    public static void Reverse(int[] array)
    {
        Array.Reverse(array);

        Console.WriteLine("Reversed Array:");

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}