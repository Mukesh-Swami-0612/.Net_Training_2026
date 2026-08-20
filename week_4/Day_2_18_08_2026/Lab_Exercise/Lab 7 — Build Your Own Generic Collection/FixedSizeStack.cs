using System;
using System.Collections;
using System.Collections.Generic;

// Summary: Generic fixed-size stack that supports Push, Pop, Peek, foreach, and Count.
// Uses an array internally because the lab requires a collection with fixed capacity.
public class FixedSizeStack<T> : IEnumerable<T>, IReadOnlyCollection<T>
{
    // Stores the stack elements internally.
    private readonly T[] _items;

    // Stores the current number of elements in the stack.
    private int _count;

    // Returns the current number of elements in the stack.
    public int Count => _count;

    // Returns the maximum number of elements the stack can contain.
    public int Capacity => _items.Length;

    // Summary: Creates a FixedSizeStack with the specified fixed capacity.
    public FixedSizeStack(int capacity)
    {
        // Capacity must be greater than zero.
        if (capacity <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(capacity),
                "Capacity must be greater than zero.");
        }

        // Create the internal array using the specified capacity.
        _items = new T[capacity];

        // Initially the stack contains no elements.
        _count = 0;
    }

    // Summary: Adds an item to the top of the stack.
    public void Push(T item)
    {
        // Do not allow another item when the stack is full.
        if (_count == Capacity)
        {
            throw new InvalidOperationException(
                "Cannot push because the stack is full.");
        }

        // Store the item at the next available position.
        _items[_count] = item;

        // Increase the number of elements.
        _count++;
    }

    // Summary: Removes and returns the top item from the stack.
    public T Pop()
    {
        // A value cannot be removed from an empty stack.
        if (_count == 0)
        {
            throw new InvalidOperationException(
                "Cannot pop because the stack is empty.");
        }

        // Move the count back to the position of the top item.
        _count--;

        // Store the top item before clearing its position.
        T item = _items[_count];

        // Clear the old position.
        _items[_count] = default!;

        // Return the removed item.
        return item;
    }

    // Summary: Returns the top item without removing it from the stack.
    public T Peek()
    {
        // A value cannot be viewed when the stack is empty.
        if (_count == 0)
        {
            throw new InvalidOperationException(
                "Cannot peek because the stack is empty.");
        }

        // Return the item at the top of the stack.
        return _items[_count - 1];
    }

    // Summary: Provides top-to-bottom iteration so the class can be used with foreach.
    public IEnumerator<T> GetEnumerator()
    {
        // Start from the top of the stack.
        for (int i = _count - 1; i >= 0; i--)
        {
            // Return each item from top to bottom.
            yield return _items[i];
        }
    }

    // Provides the non-generic IEnumerable implementation required by the interface.
    IEnumerator IEnumerable.GetEnumerator()
    {
        // Use the generic enumerator for iteration.
        return GetEnumerator();
    }
}