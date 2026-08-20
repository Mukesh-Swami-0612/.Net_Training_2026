using System;
using System.Collections.Generic;

namespace Lab4CollectionAPI
{
    // Summary:
    // Demonstrates Snapshot() and TryAddAll() using different collection
    // implementations through the ICollection<T> interface.
    internal class Program
    {
        // Summary:
        // Entry point of the console application and demonstration of the lab.
        static void Main(string[] args)
        {
            Console.WriteLine("=== Lab 4 - The Collection API ===");
            Console.WriteLine();

            // ---------------------------------------------------------
            // 1. Create different concrete collection types.
            // ---------------------------------------------------------

            // List<T> is a dynamic array-based collection.
            List<int> list = new List<int> { 10, 20, 30 };

            // HashSet<T> stores unique values.
            HashSet<int> hashSet = new HashSet<int> { 10, 20, 30 };

            // LinkedList<T> stores elements as linked nodes.
            LinkedList<int> linkedList = new LinkedList<int>(
                new[] { 10, 20, 30 }
            );

            // ---------------------------------------------------------
            // 2. Demonstrate Snapshot() with List<T>.
            // ---------------------------------------------------------

            Console.WriteLine("----- List<T> -----");

            int[] listSnapshot = CollectionOperations.Snapshot(list);

            Console.WriteLine(
                "Snapshot: " + string.Join(", ", listSnapshot));

            bool listAdded = CollectionOperations.TryAddAll(
                list,
                new[] { 40, 50 }
            );

            Console.WriteLine("TryAddAll result: " + listAdded);

            Console.WriteLine(
                "List after adding: " + string.Join(", ", list));

            Console.WriteLine();

            // ---------------------------------------------------------
            // 3. Demonstrate Snapshot() with HashSet<T>.
            // ---------------------------------------------------------

            Console.WriteLine("----- HashSet<T> -----");

            int[] hashSetSnapshot =
                CollectionOperations.Snapshot(hashSet);

            Console.WriteLine(
                "Snapshot: " + string.Join(", ", hashSetSnapshot));

            bool hashSetAdded = CollectionOperations.TryAddAll(
                hashSet,
                new[] { 40, 50 }
            );

            Console.WriteLine("TryAddAll result: " + hashSetAdded);

            Console.WriteLine(
                "HashSet after adding: " +
                string.Join(", ", hashSet));

            Console.WriteLine();

            // ---------------------------------------------------------
            // 4. Demonstrate Snapshot() with LinkedList<T>.
            // ---------------------------------------------------------

            Console.WriteLine("----- LinkedList<T> -----");

            int[] linkedListSnapshot =
                CollectionOperations.Snapshot(linkedList);

            Console.WriteLine(
                "Snapshot: " + string.Join(", ", linkedListSnapshot));

            bool linkedListAdded = CollectionOperations.TryAddAll(
                linkedList,
                new[] { 40, 50 }
            );

            Console.WriteLine("TryAddAll result: " + linkedListAdded);

            Console.WriteLine(
                "LinkedList after adding: " +
                string.Join(", ", linkedList));

            Console.WriteLine();

            // ---------------------------------------------------------
            // 5. Demonstrate read-only collection.
            // ---------------------------------------------------------

            Console.WriteLine("----- Read-Only Collection -----");

            int[] numbers = { 100, 200, 300 };

            // Create a read-only wrapper around the array.
            IList<int> readOnlyList = Array.AsReadOnly(numbers);

            // ICollection<T> is implemented by the read-only wrapper.
            ICollection<int> readOnlyCollection = readOnlyList;

            Console.WriteLine(
                "IsReadOnly: " + readOnlyCollection.IsReadOnly);

            // Try to add items to the read-only collection.
            bool readOnlyResult = CollectionOperations.TryAddAll(
                readOnlyCollection,
                new[] { 400, 500 }
            );

            Console.WriteLine(
                "TryAddAll result: " + readOnlyResult);

            // The original collection remains unchanged.
            Console.WriteLine(
                "Read-only collection: " +
                string.Join(", ", readOnlyCollection));

            Console.WriteLine();

            // ---------------------------------------------------------
            // 6. Final message.
            // ---------------------------------------------------------

            Console.WriteLine("=== Demonstration Complete ===");
        }
    }
}