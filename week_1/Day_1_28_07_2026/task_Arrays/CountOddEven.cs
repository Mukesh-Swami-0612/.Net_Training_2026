using System;

public class CountOddEven
{
    public static void Count(int[] array)
    {
        int evenCount = 0;
        int oddCount = 0;

        foreach (int num in array)
        {
            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine("Even Count : " + evenCount);
        Console.WriteLine("Odd Count : " + oddCount);
    }
}