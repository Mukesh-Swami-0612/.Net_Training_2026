using System;

namespace Lab1Tuples
{
    // Summary:
    // Provides age parsing functionality using the Try-pattern.
    // Demonstrates returning success information and an error message using a tuple.
    public static class AgeParser
    {
        // Summary:
        // Attempts to convert the input into a valid age.
        // Returns Success and ErrorMessage instead of throwing an exception
        // for expected invalid input.
        public static (bool Success, string? ErrorMessage) TryParseAge(
            string input)
        {
            // Check whether the input is null or empty.
            if (string.IsNullOrWhiteSpace(input))
            {
                return (false, "Age cannot be empty.");
            }

            // Try converting the input into an integer.
            if (!int.TryParse(input, out int age))
            {
                return (false, "Age must be a number.");
            }

            // Check whether the age is within the expected range.
            if (age < 0 || age > 120)
            {
                return (false, "Age must be between 0 and 120.");
            }

            // The input is valid.
            return (true, null);
        }
    }
}