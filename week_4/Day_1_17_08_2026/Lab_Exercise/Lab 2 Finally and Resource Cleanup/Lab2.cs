using System;

public class Lab2
{
    // Demonstrates that finally executes in all three situations:
    // normal execution, exception, and early return.
    public static void Process(int mode)
    {
        Console.WriteLine("Opening");

        try
        {
            // Mode 1: Simulate an exception
            if (mode == 1)
            {
                throw new InvalidOperationException("Simulated failure");
            }

            Console.WriteLine("Working");

            // Mode 2: Return early from the method
            if (mode == 2)
            {
                return;
            }

            Console.WriteLine("Finishing normally");
        }
        finally
        {
            // This always executes before the method exits.
            Console.WriteLine("Closing");
        }
    }


    // Demonstrates automatic resource cleanup using using.
    public static void UsingDemo()
    {
        try
        {
            // The using statement automatically calls Dispose()
            // when execution leaves this block.
            using (FakeFileHandle handle = new FakeFileHandle())
            {
                // Simulate some work with the resource.
                Console.WriteLine("Working with handle");

                // Simulate an exception.
                throw new Exception("Simulated resource failure");
            }
        }
        catch (Exception e)
        {
            // Catch the simulated exception.
            Console.WriteLine("Caught: " + e.Message);
        }
    }
}