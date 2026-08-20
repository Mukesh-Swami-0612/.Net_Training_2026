using System;

namespace Lab6Generics
{
    // Summary: Main program class used to test all generic methods and classes.
    class Program
    {
        // Summary: Entry point of the console application.
        static void Main(string[] args)
        {
            // Test Generic Swap with int.
            Console.WriteLine("===== 1. Generic Swap =====");

            int firstNumber = 10;
            int secondNumber = 20;

            Console.WriteLine($"Before Swap: {firstNumber}, {secondNumber}");

            GenericMethods.Swap(ref firstNumber, ref secondNumber);

            Console.WriteLine($"After Swap: {firstNumber}, {secondNumber}");

            // Test Generic Swap with string.
            string firstName = "Mukesh";
            string secondName = "Kumar";

            Console.WriteLine($"\nBefore Swap: {firstName}, {secondName}");

            GenericMethods.Swap(ref firstName, ref secondName);

            Console.WriteLine($"After Swap: {firstName}, {secondName}");


            // Test Pair with int and string.
            Console.WriteLine("\n===== 2. Generic Pair =====");

            Pair<int, string> student =
                new Pair<int, string>(101, "Mukesh");

            Console.WriteLine(student);

            // Test Pair with string and double.
            Pair<string, double> productPrice =
                new Pair<string, double>("Laptop", 75000);

            Console.WriteLine(productPrice);


            // Test MinMaxTracker with int.
            Console.WriteLine("\n===== 3. MinMaxTracker =====");

            MinMaxTracker<int> numberTracker =
                new MinMaxTracker<int>();

            numberTracker.Add(50);
            numberTracker.Add(10);
            numberTracker.Add(80);
            numberTracker.Add(30);

            Console.WriteLine($"Integer Min: {numberTracker.Min}");
            Console.WriteLine($"Integer Max: {numberTracker.Max}");

            // Test MinMaxTracker with custom Product class.
            MinMaxTracker<Product> productTracker =
                new MinMaxTracker<Product>();

            productTracker.Add(new Product("Mouse", 500));
            productTracker.Add(new Product("Keyboard", 1500));
            productTracker.Add(new Product("Monitor", 12000));

            Console.WriteLine($"Product Min: {productTracker.Min}");
            Console.WriteLine($"Product Max: {productTracker.Max}");


            // Test AllMatch with int.
            Console.WriteLine("\n===== 4. AllMatch =====");

            int[] numbers = { 2, 4, 6, 8 };

            bool allEven = GenericMethods.AllMatch(
                numbers,
                number => number % 2 == 0
            );

            Console.WriteLine($"Are all numbers even? {allEven}");

            // Test AllMatch with string.
            string[] names =
            {
                "Mukesh",
                "Kumar",
                "Microsoft"
            };

            bool allLongNames = GenericMethods.AllMatch(
                names,
                name => name.Length >= 5
            );

            Console.WriteLine(
                $"Are all names at least 5 characters? {allLongNames}"
            );

        }
    }
}