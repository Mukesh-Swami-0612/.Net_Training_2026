using System.Collections.Generic;

public static class FibonacciIterator
{
    // Returns Fibonacci numbers indefinitely.
    // The caller decides how many values to consume.
    public static IEnumerable<int> Fibonacci()
    {
        int first = 0;
        int second = 1;

        while (true)
        {
            // Return the current Fibonacci number.
            yield return first;

            // Calculate the next Fibonacci number.
            int next = first + second;

            first = second;
            second = next;
        }
    }
}