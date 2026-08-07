using System;

class Program
{
    // Handles positive numbers and takes -1 step
    static bool IsPositiveChain(int n)
    {
        // Base case: number has reached zero
        if (n == 0)
            return true;

        // Continue only if number is positive
        if (n > 0)
            return IsNegativeChain(n - 1);

        return false;
    }

    // Handles negative numbers and takes +1 step
    static bool IsNegativeChain(int n)
    {
        // Base case: number has reached zero
        if (n == 0)
            return true;

        // Continue only if number is negative
        if (n < 0)
            return IsPositiveChain(n + 1);

        return false;
    }

    static void Main()
    {
        int number = 5;

        bool result;

        if (number >= 0)
            result = IsPositiveChain(number);
        else
            result = IsNegativeChain(number);

        Console.WriteLine("Number: " + number);
        Console.WriteLine("Reaches zero: " + result);
    }
}