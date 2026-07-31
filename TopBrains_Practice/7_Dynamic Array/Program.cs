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
    /// Processes all dynamic array queries.
    /// </summary>
    /// <param name="n">Number of sequences.</param>
    /// <param name="queries">List of queries.</param>
    /// <returns>List containing all lastAnswer values.</returns>
    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        // Create the answer list.
        List<int> result = new List<int>();

        // Create n empty sequences.
        List<List<int>> sequences = new List<List<int>>();

        // Initialize all sequences.
        for (int i = 0; i < n; i++)
        {
            sequences.Add(new List<int>());
        }

        // Initialize lastAnswer.
        int lastAnswer = 0;

        // Process every query.
        foreach (List<int> query in queries)
        {
            // Read query type.
            int type = query[0];

            // Read x.
            int x = query[1];

            // Read y.
            int y = query[2];

            // Compute sequence index.
            int index = (x ^ lastAnswer) % n;

            // Query Type 1.
            if (type == 1)
            {
                // Append y to the sequence.
                sequences[index].Add(y);
            }
            // Query Type 2.
            else if (type == 2)
            {
                // Calculate element index.
                int position = y % sequences[index].Count;

                // Update lastAnswer.
                lastAnswer = sequences[index][position];

                // Store lastAnswer.
                result.Add(lastAnswer);
            }
        }

        // Return all answers.
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Read first line.
        string[] firstInput = Console.ReadLine().Split(' ');

        // Read n.
        int n = Convert.ToInt32(firstInput[0]);

        // Read number of queries.
        int q = Convert.ToInt32(firstInput[1]);

        // Store all queries.
        List<List<int>> queries = new List<List<int>>();

        // Read every query.
        for (int i = 0; i < q; i++)
        {
            List<int> query = Console.ReadLine()
                                     .Split(' ')
                                     .Select(int.Parse)
                                     .ToList();

            queries.Add(query);
        }

        // Execute all queries.
        List<int> result = Result.dynamicArray(n, queries);

        // Display answers.
        foreach (int answer in result)
        {
            Console.WriteLine(answer);
        }
    }
}