using System;
using System.Collections.Generic;

public static class LazyDemo
{
    // Demonstrates lazy execution of an iterator.
    public static IEnumerable<int> GenerateNumbers()
    {
        Console.WriteLine("Iterator started.");

        Console.WriteLine("Producing 1.");
        yield return 1;

        Console.WriteLine("Producing 2.");
        yield return 2;

        Console.WriteLine("Producing 3.");
        yield return 3;

        Console.WriteLine("Iterator finished.");
    }
}