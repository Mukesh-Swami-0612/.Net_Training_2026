using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1Tuples
{
    // Summary:
    // Provides methods for calculating statistical information.
    // Demonstrates returning multiple values using a named ValueTuple.
    public static class StatisticsService
    {
        // Summary:
        // Calculates and returns the average, minimum, and maximum values.
        // The results are returned together as a named ValueTuple.
        public static (double Average, double Min, double Max) GetStats(
            IEnumerable<double> values)
        {
            // Check whether the collection is null.
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            // Convert the values into a list so that we can
            // safely perform multiple operations on the collection.
            var numbers = values.ToList();

            // Make sure the collection contains at least one value.
            if (numbers.Count == 0)
            {
                throw new ArgumentException(
                    "The collection cannot be empty.",
                    nameof(values));
            }

            // Calculate the average.
            double average = numbers.Average();

            // Find the minimum value.
            double minimum = numbers.Min();

            // Find the maximum value.
            double maximum = numbers.Max();

            // Return all three values as a named tuple.
            return (average, minimum, maximum);
        }
    }
}