using System;
using System.Collections.Generic;

namespace Lab4_GenericDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. FUNC<> - Addition and Multiplication

            // Func<int, int, int> takes two int values
            // and returns an int value.

            Func<int, int, int> addition = (a, b) => a + b;

            Func<int, int, int> multiplication = (a, b) => a * b;

            int additionResult = addition(10, 5);

            int multiplicationResult = multiplication(10, 5);

            Console.WriteLine("=== FUNC<> DEMO ===");
            Console.WriteLine($"10 + 5 = {additionResult}");
            Console.WriteLine($"10 * 5 = {multiplicationResult}");


            // 2. ACTION<> - Logging Message

            // Action<string> accepts one string
            // and does not return anything.

            Action<string> logMessage = message =>
            {
                Console.WriteLine(
                    $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}"
                );
            };

            Console.WriteLine();
            Console.WriteLine("=== ACTION<> DEMO ===");

            logMessage("This is a test log message.");


            // 3. PREDICATE<T> - Prime Number Checking

            // Predicate<int> accepts an integer
            // and returns true or false.

            Predicate<int> isPrime = PrimeChecker.IsPrime;

            List<int> numbers = new List<int>();

            // Add numbers from 1 to 50.
            for (int i = 1; i <= 50; i++)
            {
                numbers.Add(i);
            }

            // FindAll uses the Predicate<int>
            // to keep only numbers for which the predicate returns true.

            List<int> primeNumbers = numbers.FindAll(isPrime);

            Console.WriteLine();
            Console.WriteLine("=== PREDICATE<T> DEMO ===");

            Console.WriteLine("Prime numbers from 1 to 50:");

            foreach (int number in primeNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();


            // 4. ACTION + REPEAT METHOD

            Console.WriteLine();
            Console.WriteLine("=== REPEAT DEMO ===");

            // Pass a lambda expression as an Action.
            // The lambda prints "Tick".

            Repeater.Repeat(
                5,
                () => Console.WriteLine("Tick")
            );

        }
    }
}