using System;

public class PrintOddNumbers
{
    public static void PrintOdd(int[] array)
    {
        Console.WriteLine("Odd Numbers:");

        foreach (int num in array)
        {
            if (num % 2 != 0)
            {
                Console.Write(num + " ");
            }
        }

        Console.WriteLine();
    }
}