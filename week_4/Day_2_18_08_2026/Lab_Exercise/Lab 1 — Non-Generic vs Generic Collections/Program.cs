using System;

namespace Lab1Collections
{
    // Summary: Entry point of the application and starts all Lab 1 demonstrations.
    class Program
    {
        // Summary: Runs the collection demonstration and performance benchmark.
        static void Main(string[] args)
        {
            Console.WriteLine("LAB 1 - NON-GENERIC VS GENERIC COLLECTIONS");
        
            Console.WriteLine();

            // Run ArrayList and List<int> demonstrations.
            CollectionDemo.Run();

            Console.WriteLine();

            // Run the performance benchmark.
            BenchmarkDemo.Run();

        }
    }
}