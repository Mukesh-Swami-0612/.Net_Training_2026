using System;
using System.Collections.Generic;

namespace Lab4CollectionAPI
{
    // Summary:
    // Contains generic collection methods that work with ICollection<T>
    // instead of depending on a specific collection implementation.
    public static class CollectionOperations
    {
        // Summary:
        // Creates an array snapshot of any ICollection<T> using CopyTo().
        public static T[] Snapshot<T>(ICollection<T> source)
        {
            // Create an array with the same size as the collection.
            T[] snapshot = new T[source.Count];

            // Copy collection elements into the array.
            source.CopyTo(snapshot, 0);

            // Return the copied array.
            return snapshot;
        }

        // Summary:
        // Adds all items when the target is writable and refuses to modify
        // the target when it is read-only.
        public static bool TryAddAll<T>(
            ICollection<T> target,
            IEnumerable<T> items)
        {
            // Check whether the collection can be modified.
            if (target.IsReadOnly)
            {
                // Do not modify the collection.
                return false;
            }

            // Add every item to the target collection.
            foreach (T item in items)
            {
                target.Add(item);
            }

            // All items were successfully added.
            return true;
        }
    }
}