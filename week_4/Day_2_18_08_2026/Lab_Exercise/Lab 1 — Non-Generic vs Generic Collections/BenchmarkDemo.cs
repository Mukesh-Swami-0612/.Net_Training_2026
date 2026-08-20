using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab1Collections
{
    // Summary: Compares the insertion performance of ArrayList and List<int>.
    class BenchmarkDemo
    {
        // Summary: Inserts 2,000,000 integers into both collections and prints their timings.
        public static void Run()
        {
            // Number of integers to insert into each collection.
            const int itemCount = 2_000_000;

            Console.WriteLine("Part 3: Performance Benchmark");
            Console.WriteLine($"Number of integers: {itemCount:N0}");
            Console.WriteLine();

            // Start the timer for ArrayList.
            Stopwatch arrayListStopwatch = Stopwatch.StartNew();

            // Create the ArrayList.
            ArrayList arrayList = new ArrayList();

            // Insert 2,000,000 integers into the ArrayList.
            for (int i = 0; i < itemCount; i++)
            {
                arrayList.Add(i);
            }

            // Stop the ArrayList timer.
            arrayListStopwatch.Stop();

            // Start the timer for List<int>.
            Stopwatch genericListStopwatch = Stopwatch.StartNew();

            // Create the generic List<int>.
            List<int> genericList = new List<int>();

            // Insert 2,000,000 integers into the List<int>.
            for (int i = 0; i < itemCount; i++)
            {
                genericList.Add(i);
            }

            // Stop the List<int> timer.
            genericListStopwatch.Stop();

            // Display the benchmark results.
            Console.WriteLine("Benchmark Results:");
            

            // Display ArrayList insertion time.
            Console.WriteLine(
                $"ArrayList  : {arrayListStopwatch.ElapsedMilliseconds} ms");

            // Display List<int> insertion time.
            Console.WriteLine(
                $"List<int>  : {genericListStopwatch.ElapsedMilliseconds} ms");


            Console.WriteLine();

            // Display the main observation from the benchmark.
            Console.WriteLine("Observation:");
            Console.WriteLine("ArrayList stores integers as objects.");
            Console.WriteLine("List<int> is strongly typed and avoids boxing of integers.");
        }
    }
}