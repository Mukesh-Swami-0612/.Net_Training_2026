using System;
using System.Collections.Generic;

class Program
{
    // Summary: Entry point of the Lab 7 console application.
    // Calls separate methods to demonstrate the stack, extension method, and exceptions.
    static void Main()
    {
        Console.WriteLine("===== LAB 7: BUILD YOUR OWN GENERIC COLLECTION =====");
        Console.WriteLine();

        DemonstrateIntegerStack();

        Console.WriteLine();

        DemonstrateStringConversion();

        Console.WriteLine();

        DemonstrateExceptionCases();
    }

    // Summary: Demonstrates FixedSizeStack<int> with Push, Peek, Pop, Count, and foreach.
    static void DemonstrateIntegerStack()
    {
        Console.WriteLine("--- Integer Stack ---");

        // Create a stack with a fixed capacity of 3.
        FixedSizeStack<int> stack = new FixedSizeStack<int>(3);

        // Add three integers to the stack.
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // Display the current number of items.
        Console.WriteLine($"Count: {stack.Count}");

        // Display the maximum capacity.
        Console.WriteLine($"Capacity: {stack.Capacity}");

        // Peek returns the top item without removing it.
        Console.WriteLine($"Top item using Peek(): {stack.Peek()}");

        // Display stack items from top to bottom.
        Console.WriteLine("Stack items (top to bottom):");

        // IEnumerable<T> allows the stack to be used with foreach.
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        // Pop removes and returns the top item.
        int removedItem = stack.Pop();

        // Display the removed item.
        Console.WriteLine($"Popped item: {removedItem}");

        // Display the count after removing an item.
        Console.WriteLine($"Count after Pop(): {stack.Count}");
    }

    // Summary: Converts a List<string> into FixedSizeStack<string> using the extension method.
    static void DemonstrateStringConversion()
    {
        Console.WriteLine("--- List<string> to FixedSizeStack<string> ---");

        // Create a normal generic list containing strings.
        List<string> names = new List<string>
        {
            "Alice",
            "Bob",
            "Charlie"
        };

        // Convert the list into the custom fixed-size stack.
        FixedSizeStack<string> stack = names.ToFixedSizeStack(3);

        // Display the number of items in the stack.
        Console.WriteLine($"Count: {stack.Count}");

        // Display the stack from top to bottom.
        Console.WriteLine("String stack (top to bottom):");

        // Iterate through the custom stack.
        foreach (string name in stack)
        {
            Console.WriteLine(name);
        }
    }

    // Summary: Demonstrates and handles the required full-stack and empty-stack exceptions.
    static void DemonstrateExceptionCases()
    {
        Console.WriteLine("--- Exception Cases ---");

        // Create a stack with capacity of 2.
        FixedSizeStack<int> fullStack = new FixedSizeStack<int>(2);

        // Fill the stack.
        fullStack.Push(100);
        fullStack.Push(200);

        try
        {
            // This causes InvalidOperationException because the stack is full.
            fullStack.Push(300);
        }
        catch (InvalidOperationException ex)
        {
            // Print the exception instead of allowing the application to crash.
            Console.WriteLine($"Push exception: {ex.Message}");
        }

        // Create an empty stack.
        FixedSizeStack<int> emptyStack = new FixedSizeStack<int>(2);

        try
        {
            // This causes InvalidOperationException because the stack is empty.
            emptyStack.Pop();
        }
        catch (InvalidOperationException ex)
        {
            // Print the exception instead of allowing the application to crash.
            Console.WriteLine($"Pop exception: {ex.Message}");
        }

        try
        {
            // This causes InvalidOperationException because the stack is empty.
            emptyStack.Peek();
        }
        catch (InvalidOperationException ex)
        {
            // Print the exception instead of allowing the application to crash.
            Console.WriteLine($"Peek exception: {ex.Message}");
        }
    }
}