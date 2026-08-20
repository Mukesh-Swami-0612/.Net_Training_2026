using System;

public class AgeParser
{
    // Parses the input string and validates the age.
    public static int ParseAge(string input)
    {
        Console.WriteLine("Step 1");

        // Converts the string into an integer.
        // This can throw FormatException if input is not numeric.
        int age = int.Parse(input);

        // Checks whether the age is within the allowed range.
        if (age < 0 || age > 150)
        {
            throw new ArgumentOutOfRangeException(
                nameof(input),
                "Age must be between 0 and 150"
            );
        }

        // This line runs only when the age is valid.
        Console.WriteLine("Step 2 (only if valid)");

        return age;
    }
}