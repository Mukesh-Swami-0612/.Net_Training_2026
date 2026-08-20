using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an object of OrderProcessor.
        OrderProcessor processor = new OrderProcessor();


        // ---------------------------------------------------------
        // TEST 1: Missing customer name
        // ---------------------------------------------------------

        Console.WriteLine("-- Missing customer name --");

        processor.ProcessOrder(
            "",
            2,
            49.99m);


        Console.WriteLine();


        // ---------------------------------------------------------
        // TEST 2: Zero quantity
        // ---------------------------------------------------------

        Console.WriteLine("-- Zero quantity --");

        processor.ProcessOrder(
            "Alice",
            0,
            49.99m);


        Console.WriteLine();


        // ---------------------------------------------------------
        // TEST 3: Negative price
        // ---------------------------------------------------------

        Console.WriteLine("-- Negative price --");

        processor.ProcessOrder(
            "Bob",
            2,
            -10.00m);


        Console.WriteLine();


        // ---------------------------------------------------------
        // TEST 4: Valid order but database save fails
        // ---------------------------------------------------------

        Console.WriteLine("-- Valid order, SaveOrder fails --");

        processor.ProcessOrder(
            "DatabaseFailure",
            2,
            50.00m);


        Console.WriteLine();


        // ---------------------------------------------------------
        // TEST 5: Fully valid order
        // ---------------------------------------------------------

        Console.WriteLine("-- Fully valid order --");

        processor.ProcessOrder(
            "John",
            4,
            49.99m);


        Console.ReadLine();
    }
}