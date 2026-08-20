using System;
using System.Collections;
using System.Collections.Generic;

// MyList<T> is a simplified generic dynamic array.
// It supports adding, removing, indexing, foreach, and collection initializers.
public class MyList<T> : IEnumerable<T>
{
    // Internal array used to store the elements.
    private T[] _items;

    // Number of elements currently stored in the list.
    private int _count;

    // Initial capacity of the internal array.
    private const int InitialCapacity = 4;

    // Returns the number of elements currently stored.
    public int Count
    {
        get { return _count; }
    }

    // Creates an empty MyList with the initial capacity.
    public MyList()
    {
        _items = new T[InitialCapacity];
        _count = 0;
    }

    // Adds an item to the end of the list.
    public void Add(T item)
    {
        // If the internal array is full, increase its capacity.
        if (_count == _items.Length)
        {
            Grow();
        }

        // Store the new item at the next available position.
        _items[_count] = item;

        // Increase the number of stored elements.
        _count++;
    }

    // Doubles the capacity of the internal array.
    private void Grow()
    {
        // Create a new array with double the current capacity.
        T[] newItems = new T[_items.Length * 2];

        // Copy existing elements into the new array.
        Array.Copy(_items, newItems, _count);

        // Replace the old array with the new larger array.
        _items = newItems;
    }

    // Removes the element at the specified index.
    public void RemoveAt(int index)
    {
        // Check whether the index is valid.
        CheckIndex(index);

        // Move elements after the removed element one position to the left.
        for (int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }

        // Clear the last element.
        _items[_count - 1] = default!;

        // Decrease the number of stored elements.
        _count--;
    }

    // Indexer allows access like list[0] or list[1] = value.
    public T this[int index]
    {
        get
        {
            // Check whether the index is valid.
            CheckIndex(index);

            // Return the element at the requested index.
            return _items[index];
        }

        set
        {
            // Check whether the index is valid.
            CheckIndex(index);

            // Replace the element at the requested index.
            _items[index] = value;
        }
    }

    // Checks whether an index is within the valid range.
    private void CheckIndex(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException(
                nameof(index),
                "Index is outside the valid range."
            );
        }
    }

    // Returns an enumerator so that foreach can work.
    public IEnumerator<T> GetEnumerator()
    {
        // Return each stored element one by one.
        for (int i = 0; i < _count; i++)
        {
            yield return _items[i];
        }
    }

    // Required by the non-generic IEnumerable interface.
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}