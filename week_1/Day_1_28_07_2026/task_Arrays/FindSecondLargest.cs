using System;

public class FindSecondLargest
{
    public static void SecondLargest(int[] array)
    {
        int largest = array[0];
        int secondLargest = int.MinValue;

        foreach (int num in array)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }

        Console.WriteLine("Second Largest Element : " + secondLargest);
    }
}