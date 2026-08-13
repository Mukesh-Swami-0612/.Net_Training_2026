using System;

class Program
{
    // Head recursion method
    static void SumDigitsReversed(int n)
    {
        // Base case
        if (n == 0)
            return;

        // Recursive call happens first
        SumDigitsReversed(n / 10);

        // Prints digit after recursive call returns
        Console.Write(n % 10);
    }

    static void Main(string[] args)
    {
        int number = 12345;

        Console.WriteLine("Original Number: " + number);

        Console.Write("Digits in Reverse Order: ");

        SumDigitsReversed(number);

        Console.WriteLine();
    }
}