using System;
using System.Collections.Generic;

public class StackDemo<T>
{
    private readonly List<T> _items = new List<T>();

    // Push
    public void Push(T item)
    {
        _items.Add(item);
    }

    // Pop
    public T Pop()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        int lastIndex = _items.Count - 1;
        T top = _items[lastIndex];

        _items.RemoveAt(lastIndex);

        return top;
    }

    // Count
    public int Count
    {
        get
        {
            return _items.Count;
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // -------------------------------
        // Integer Stack
        // -------------------------------

        Console.WriteLine("Integer Stack Information");

        var intStack = new StackDemo<int>();

        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);

        Console.WriteLine($"Stack Count: {intStack.Count}");

        Console.WriteLine($"Stack Pop: {intStack.Pop()}");

        Console.WriteLine($"After Pop Stack Count: {intStack.Count}");

        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);

        Console.WriteLine($"Stack Count: {intStack.Count}");

        Console.WriteLine($"Stack Pop: {intStack.Pop()}");

        Console.WriteLine($"After Pop Stack Count: {intStack.Count}");


        // -------------------------------
        // Name/String Stack
        // -------------------------------

        Console.WriteLine();
        Console.WriteLine("Name Stack Information");

        var nameStack = new StackDemo<string>();

        nameStack.Push("Alice");
        nameStack.Push("John");
        nameStack.Push("Ram");

        Console.WriteLine($"Stack Count: {nameStack.Count}");

        Console.WriteLine($"Stack Pop: {nameStack.Pop()}");

        Console.WriteLine($"After Pop Stack Count: {nameStack.Count}");
    }
}