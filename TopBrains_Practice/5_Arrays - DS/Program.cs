using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /// <summary>
    /// Reverses the given array using the two-pointer approach.
    /// </summary>
    /// <param name="a">Input integer list.</param>
    /// <returns>Reversed integer list.</returns>
    public static List<int> ReverseArray(List<int> a)
    {
        // Initialize the left pointer.
        int left = 0;

        // Initialize the right pointer.
        int right = a.Count - 1;

        // Continue until both pointers meet.
        while (left < right)
        {
            // Store the left element temporarily.
            int temp = a[left];

            // Move the right element to the left position.
            a[left] = a[right];

            // Move the temporary value to the right position.
            a[right] = temp;

            // Move the left pointer forward.
            left++;

            // Move the right pointer backward.
            right--;
        }

        // Return the reversed array.
        return a;
    }
}

class Program
{
    /// <summary>
    /// Entry point of the application.
    /// </summary>
    static void Main(string[] args)
    {
        // Ask the user to enter the array size.
        Console.Write("Enter the number of elements: ");

        // Read the array size.
        int n = Convert.ToInt32(Console.ReadLine());

        // Ask the user to enter the array elements.
        Console.WriteLine("Enter the array elements separated by spaces:");

        // Read the elements and convert them into a list.
        List<int> arr = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToList();

        // Check whether the entered size matches the number of elements.
        if (arr.Count != n)
        {
            Console.WriteLine("Invalid input! Number of elements does not match the specified size.");
            return;
        }

        // Call the reverseArray method.
        List<int> result = Result.ReverseArray(arr);

        // Display the reversed array.
        Console.WriteLine("\nReversed Array:");

        // Print each element.
        foreach (int item in result)
        {
            Console.Write(item + " ");
        }

        // Move to the next line.
        Console.WriteLine();
    }
}