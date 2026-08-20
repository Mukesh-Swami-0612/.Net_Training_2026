using System;
using System.Collections;
using System.Collections.Generic;

public class MyList<T> : IEnumerable<T>
{
    // Internal array used to store elements.
    private T[] items;

    // Number of elements currently stored.
    public int Count { get; private set; }

    // Creates a list with an initial capacity.
    public MyList(int capacity = 4)
    {
        items = new T[capacity];
        Count = 0;
    }

    // Adds an item to the list.
    public void Add(T item)
    {
        // Increase capacity when the array is full.
        if (Count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }

        // Store the item.
        items[Count] = item;

        // Increase the number of stored elements.
        Count++;
    }

    // Gets or sets an element using its index.
    public T this[int index]
    {
        get
        {
            // Validate the index.
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            return items[index];
        }

        set
        {
            // Validate the index.
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            items[index] = value;
        }
    }

    // Removes an element at the specified index.
    public void RemoveAt(int index)
    {
        // Validate the index.
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        // Shift elements to the left.
        for (int i = index; i < Count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        // Clear the unused final position.
        items[Count - 1] = default!;

        Count--;
    }

    // Normal forward iterator.
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return items[i];
        }
    }

    // Required non-generic IEnumerable implementation.
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // ============================================================
    // LAB 8 ADDITION
    // ============================================================

    // Returns elements from the last element to the first.
    // No second array is allocated.
    public IEnumerable<T> InReverse()
    {
        for (int i = Count - 1; i >= 0; i--)
        {
            yield return items[i];
        }
    }
}