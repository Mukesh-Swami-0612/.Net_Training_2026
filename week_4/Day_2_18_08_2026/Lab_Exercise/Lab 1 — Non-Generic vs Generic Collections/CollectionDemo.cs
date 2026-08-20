using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab1Collections
{
    // Summary: Demonstrates the difference between ArrayList and List<int>.
    class CollectionDemo
    {
        // Summary: Runs the ArrayList and generic List<int> demonstrations.
        public static void Run()
        {
            Console.WriteLine("----- Part 1: ArrayList -----");

            // Demonstrate the non-generic collection.
            DemonstrateArrayList();

            Console.WriteLine();

            Console.WriteLine("----- Part 2: List<int> -----");

            // Demonstrate the generic collection.
            DemonstrateGenericList();
        }

        // Summary: Demonstrates storing different data types in an ArrayList and finding numeric values.
        private static void DemonstrateArrayList()
        {
            // Create a non-generic collection.
            ArrayList values = new ArrayList();

            // ArrayList can store different types of values.
            values.Add(10);
            values.Add("twenty");
            values.Add(30.5);
            values.Add(true);

            // Variable used to store the numeric sum.
            double sum = 0;

            // Read each value from the ArrayList.
            foreach (object value in values)
            {
                // Check if the value is an integer.
                if (value is int intValue)
                {
                    // Add the integer to the sum.
                    sum += intValue;
                }

                // Check if the value is a double.
                else if (value is double doubleValue)
                {
                    // Add the double to the sum.
                    sum += doubleValue;
                }
            }

            Console.WriteLine("Values in ArrayList:");

            // Display all values and their types.
            foreach (object value in values)
            {
                Console.WriteLine($"  {value} ({value.GetType().Name})");
            }

            // Display the sum of numeric values.
            Console.WriteLine($"Numeric sum = {sum}");

            Console.WriteLine();

            // Explain the main problem with ArrayList.
            Console.WriteLine("Problem with ArrayList:");
            Console.WriteLine("It can contain different data types.");
            Console.WriteLine("We must check and cast the values ourselves.");
        }

        // Summary: Demonstrates type safety using a generic List<int>.
        private static void DemonstrateGenericList()
        {
            // Create a generic collection that accepts only integers.
            List<int> numbers = new List<int>();

            // Add integer values to the list.
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            // Variable used to store the sum.
            int sum = 0;

            // Read each integer from the list.
            foreach (int number in numbers)
            {
                // Add the current number to the sum.
                sum += number;
            }

            // Display the sum.
            Console.WriteLine($"List<int> sum = {sum}");

            Console.WriteLine();

            // Explain the type-safety feature.
            Console.WriteLine("List<int> accepts only integers.");

           
        }
    }
}