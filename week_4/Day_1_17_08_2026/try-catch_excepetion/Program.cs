using System;

// Main class of the program
class Program
{
    // Main method - program execution starts here
    public static void Main()
    {
        // Run single exception example
        Console.WriteLine("Single Exception Example");
        SingleException.Run();

        // Run multiple exception example
        Console.WriteLine("Multiple Exception Example");
        MultipleException.Run();

        // Run throw exception example
        Console.WriteLine("Throw Exception Example");
        ThrowException.Run();

        // Run finally block example
        Console.WriteLine("Finally Block Example");
        FinallyBlock.Run();

        // Run user-defined exception example
        Console.WriteLine("User Defined Exception Example");
        UserDefinedException.Run();
    }
}