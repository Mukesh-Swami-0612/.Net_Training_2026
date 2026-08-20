using System.Collections.Generic;

public static class PositiveIterator
{
    // Returns values until the first non-positive value is found.
    public static IEnumerable<int> TakeWhilePositive(
        IEnumerable<int> source)
    {
        foreach (int number in source)
        {
            // Stop the iterator when the number is zero or negative.
            if (number <= 0)
            {
                yield break;
            }

            // Return the current positive number.
            yield return number;
        }
    }
}