using System;
using System.Collections.Generic;

// Summary: Contains extension methods for working with FixedSizeStack<T>.
public static class StackExtensions
{
    // Summary: Converts an IEnumerable<T> into a FixedSizeStack<T> with the given capacity.
    public static FixedSizeStack<T> ToFixedSizeStack<T>(
        this IEnumerable<T> source,
        int capacity)
    {
        // The source collection cannot be null.
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        // Create a new fixed-size stack with the requested capacity.
        FixedSizeStack<T> stack = new FixedSizeStack<T>(capacity);

        // Add every item from the source collection to the stack.
        foreach (T item in source)
        {
            stack.Push(item);
        }

        // Return the newly created stack.
        return stack;
    }
}