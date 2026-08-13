using System;

class Program
{
    // Calculates factorial using tail recursion
    static int Factorial(int n, int accumulator = 1)
    {
        // Base case
        if (n <= 1)
            return accumulator;

        // Recursive call is the last operation
        return Factorial(n - 1, accumulator * n);
    }

    static void Main()
    {
        int number = 5;

        int result = Factorial(number);

        Console.WriteLine("Factorial of " + number + " = " + result);
    }
}