using System;

class ValidationDemo
{
    // Validates the input value.
    // Throws a new ArgumentOutOfRangeException
    // when the value is negative.

    public static void Validate(int value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(value),
                value,
                "Value cannot be negative.");
        }
    }
}