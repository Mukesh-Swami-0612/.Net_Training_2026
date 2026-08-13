using System;

class Program
{
    // =========================================================
    // 1. HEAD RECURSION
    // =========================================================
    static void HeadRecursion(int n)
    {
        // Base case
        if (n == 0)
            return;

        // Recursive call happens BEFORE remaining work
        HeadRecursion(n - 1);

        // This executes after the recursive call returns
        Console.WriteLine(n);
    }


    // =========================================================
    // 2. TAIL RECURSION
    // =========================================================
    static void TailRecursion(int n)
    {
        // Base case
        if (n == 0)
            return;

        // Work is performed before the recursive call
        Console.WriteLine(n);

        // Recursive call is the LAST operation
        TailRecursion(n - 1);
    }


    // =========================================================
    // 3. TREE RECURSION
    // =========================================================
    static int TreeRecursion(int n)
    {
        // Base case
        if (n <= 1)
            return 1;

        // Two recursive calls create multiple branches
        return TreeRecursion(n - 1) + TreeRecursion(n - 2);
    }


    // =========================================================
    // 4. INDIRECT RECURSION
    // =========================================================
    static bool IsEven(int n)
    {
        // Base case
        if (n == 0)
            return true;

        // IsEven calls IsOdd
        return IsOdd(n - 1);
    }

    static bool IsOdd(int n)
    {
        // Base case
        if (n == 0)
            return false;

        // IsOdd calls IsEven
        return IsEven(n - 1);
    }


    // =========================================================
    // MAIN METHOD
    // =========================================================
    static void Main(string[] args)
    {
        Console.WriteLine("===== HEAD RECURSION =====");

        HeadRecursion(5);

        Console.WriteLine();


        Console.WriteLine("===== TAIL RECURSION =====");

        TailRecursion(5);

        Console.WriteLine();


        Console.WriteLine("===== TREE RECURSION =====");

        int treeResult = TreeRecursion(5);

        Console.WriteLine("Result: " + treeResult);

        Console.WriteLine();


        Console.WriteLine("===== INDIRECT RECURSION =====");

        int number = 6;

        bool result;

        if (number % 2 == 0)
            result = IsEven(number);
        else
            result = IsOdd(number);

        Console.WriteLine(
            number + " is even: " + result
        );
    }
}