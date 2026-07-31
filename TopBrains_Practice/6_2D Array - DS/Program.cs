using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /// <summary>
    /// Finds the maximum hourglass sum in a 6x6 array.
    /// </summary>
    /// <param name="arr">Two-dimensional integer array.</param>
    /// <returns>Maximum hourglass sum.</returns>
    public static int hourglassSum(List<List<int>> arr)
    {
        // Store the smallest possible integer.
        int maxSum = int.MinValue;

        // Traverse rows.
        for (int i = 0; i <= 3; i++)
        {
            // Traverse columns.
            for (int j = 0; j <= 3; j++)
            {
                // Calculate the current hourglass sum.
                int currentSum =
                    arr[i][j] +
                    arr[i][j + 1] +
                    arr[i][j + 2] +
                    arr[i + 1][j + 1] +
                    arr[i + 2][j] +
                    arr[i + 2][j + 1] +
                    arr[i + 2][j + 2];

                // Update maximum sum if needed.
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }

        // Return the maximum hourglass sum.
        return maxSum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Create a list to store the 2D array.
        List<List<int>> arr = new List<List<int>>();

        // Read six rows.
        for (int i = 0; i < 6; i++)
        {
            // Read one row and convert it to integers.
            arr.Add(Console.ReadLine()
                           .Split(' ')
                           .Select(int.Parse)
                           .ToList());
        }

        // Calculate the maximum hourglass sum.
        int result = Result.hourglassSum(arr);

        // Display the result.
        Console.WriteLine(result);
    }
}