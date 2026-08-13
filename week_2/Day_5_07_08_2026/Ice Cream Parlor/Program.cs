using System;
using System.Collections.Generic;

class Result
{
    /*
     * This function finds two ice cream flavors
     * whose prices add up to the money available.
     */
    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        // Check every price
        for (int i = 0; i < arr.Count; i++)
        {
            // Check the prices after the current price
            for (int j = i + 1; j < arr.Count; j++)
            {
                // Check if the two prices add up to m
                if (arr[i] + arr[j] == m)
                {
                    // Create a list to store the answer
                    List<int> result = new List<int>();

                    // Add 1 because the question uses 1-based indexing
                    result.Add(i + 1);
                    result.Add(j + 1);

                    return result;
                }
            }
        }

        // Return empty list if no pair is found
        return new List<int>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Number of trips
        int t = 2;

        
        // FIRST TRIP
        // Money available
        int m1 = 4;

        // Number of flavors
        int n1 = 5;

        // Prices of the flavors
        List<int> arr1 = new List<int>()
        {
            1, 4, 5, 3, 2
        };

        // Call the function
        List<int> result1 = Result.icecreamParlor(m1, arr1);

        // Display result
        Console.WriteLine("First Trip:");
        Console.WriteLine(String.Join(" ", result1));



        // SECOND TRIP

        // Money available
        int m2 = 4;

        // Number of flavors
        int n2 = 4;

        // Prices of the flavors
        List<int> arr2 = new List<int>()
        {
            2, 2, 4, 3
        };

        // Call the function
        List<int> result2 = Result.icecreamParlor(m2, arr2);

        // Display result
        Console.WriteLine("Second Trip:");
        Console.WriteLine(String.Join(" ", result2));


        // Keep console window open
        Console.ReadLine();
    }
}