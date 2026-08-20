using System;

class Program
{
    static void Main(string[] args)
    {
        // -----------------------------------------
        // Process(0) - Normal execution
        // -----------------------------------------
        Console.WriteLine("-- Process(0) --");

        Lab2.Process(0);


        // -----------------------------------------
        // Process(1) - Exception execution
        // -----------------------------------------
        Console.WriteLine();
        Console.WriteLine("-- Process(1) --");

        try
        {
            Lab2.Process(1);
        }
        catch (Exception e)
        {
            // Catch the exception thrown by Process(1).
            Console.WriteLine("Caught: " + e.Message);
        }


        // -----------------------------------------
        // Process(2) - Early return
        // -----------------------------------------
        Console.WriteLine();
        Console.WriteLine("-- Process(2) --");

        Lab2.Process(2);


        // -----------------------------------------
        // using / IDisposable demonstration
        // -----------------------------------------
        Console.WriteLine();
        Console.WriteLine("-- using / IDisposable --");

        Lab2.UsingDemo();


        Console.ReadLine();
    }
}