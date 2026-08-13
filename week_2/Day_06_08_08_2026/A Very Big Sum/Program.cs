using System;
using System.Collections.Generic;

class Result
{
    /*
     * This function calculates the sum
     * of all numbers in the array.
     */
    public static long aVeryBigSum(List<long> ar)
    {
        // Variable to store the total sum
        long sum = 0;

        // Go through every number in the list
        foreach (long number in ar)
        {
            sum = sum + number;
        }

        // Return the final sum
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Read the number of elements
        int n = Convert.ToInt32(Console.ReadLine());

        // Read the numbers from the user
        string[] input = Console.ReadLine().Split(' ');

        // Create a list to store the numbers
        List<long> ar = new List<long>();

        // Convert each input value to long
        for (int i = 0; i < n; i++)
        {
            ar.Add(Convert.ToInt64(input[i]));
        }

        // Call the function
        long result = Result.aVeryBigSum(ar);

        // Print the result
        Console.WriteLine(result);
    }
}