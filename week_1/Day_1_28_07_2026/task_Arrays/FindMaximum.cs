using System;

public class FindMaximum
{
    public static void Maximum(int[] array)
    {
        int max = array[0];

        foreach (int num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine("Maximum Element : " + max);
    }
}