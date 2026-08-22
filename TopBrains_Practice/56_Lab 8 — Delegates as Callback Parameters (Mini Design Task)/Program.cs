using System;
using System.Collections.Generic;

namespace Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an object of BatchProcessor.
            BatchProcessor processor = new BatchProcessor();


            // PART 1: Process integers
            // Create a list of integers.
            List<int> numbers = new List<int>
            {
                10,
                -5,
                20,
                -2,
                30
            };

            Console.WriteLine("===== INTEGER BATCH =====");

            // Call the generic ProcessBatch method for integers.
            processor.ProcessBatch(
                numbers,

                // Success callback:
                // This runs when the number is valid.
                number =>
                    Console.WriteLine($"SUCCESS: {number} is valid."),

                // Failure callback:
                // This runs when the number is invalid.
                (number, reason) =>
                    Console.WriteLine(
                        $"FAILURE: {number} is invalid. Reason: Negative number."),

                // Validator:
                // Negative numbers are rejected.
                number => number >= 0
            );

            Console.WriteLine();

            // PART 2: Process strings

            // Create a list of strings.
            List<string> names = new List<string>
            {
                "Mukesh",
                "",
                "John",
                "   ",
                "Alice"
            };

            Console.WriteLine("===== STRING BATCH =====");

            // Call the SAME generic ProcessBatch method,
            // but this time T becomes string.
            processor.ProcessBatch(
                names,

                // Success callback:
                // This runs when the string is valid.
                name =>
                    Console.WriteLine($"SUCCESS: '{name}' is valid."),

                // Failure callback:
                // This runs when the string is invalid.
                (name, reason) =>
                    Console.WriteLine(
                        $"FAILURE: '{name}' is invalid. Reason: Empty or whitespace."),

                // Validator:
                // Empty and whitespace-only strings are rejected.
                name => !string.IsNullOrWhiteSpace(name)
            );

            Console.WriteLine();

            Console.WriteLine("Processing completed.");
        }
    }
}