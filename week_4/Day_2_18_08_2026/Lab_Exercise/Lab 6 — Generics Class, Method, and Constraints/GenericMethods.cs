using System;
using System.Collections.Generic;

namespace Lab6Generics
{
    // Summary: Contains generic methods that can work with different data types.
    public static class GenericMethods
    {
        // Summary: Swaps two values of any data type using a generic type parameter.
        public static void Swap<T>(ref T a, ref T b)
        {
            // Store the first value temporarily.
            T temp = a;

            // Assign the second value to the first variable.
            a = b;

            // Assign the original first value to the second variable.
            b = temp;
        }

        // Summary: Returns true only when every item satisfies the given condition.
        public static bool AllMatch<T>(
            IEnumerable<T> items,
            Func<T, bool> predicate)
        {
            // Check every item in the collection.
            foreach (T item in items)
            {
                // Return false when an item does not satisfy the condition.
                if (!predicate(item))
                {
                    return false;
                }
            }

            // Return true when all items satisfy the condition.
            return true;
        }
    }
}