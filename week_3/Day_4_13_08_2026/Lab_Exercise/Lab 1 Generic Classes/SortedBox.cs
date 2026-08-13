using System;
using System.Collections.Generic;

public class SortedBox<T> where T : IComparable<T>
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
        _items.Sort();
    }

    public List<T> GetItems()
    {
        return _items;
    }
}