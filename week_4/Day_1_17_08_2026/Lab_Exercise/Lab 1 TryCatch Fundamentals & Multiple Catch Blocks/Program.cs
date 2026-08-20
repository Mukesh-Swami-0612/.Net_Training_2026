using System;

class Program
{
    static void Main(string[] args)
    {
        // TEST 1: Non-numeric input

        Console.WriteLine("-- ParseAge(\"abc\") --");

        try
        {
            int result = AgeParser.ParseAge("abc");

            Console.WriteLine("Result: " + result);
        }
        catch (FormatException ex)
        {
            // This catch handles invalid numeric format.
            Console.WriteLine("Caught FormatException: " + ex.Message);
        }
        catch (Exception ex)
        {
            // General exception handler.
            Console.WriteLine("Caught general Exception: " + ex.Message);
        }


        // TEST 2: Number is outside allowed range

        Console.WriteLine();
        Console.WriteLine("-- ParseAge(\"200\") --");

        try
        {
            int result = AgeParser.ParseAge("200");

            Console.WriteLine("Result: " + result);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            // Most specific exception.
            Console.WriteLine(
                "Caught ArgumentOutOfRangeException " +
                "(most specific, ran first): " +
                ex.Message
            );
        }
        catch (ArgumentException ex)
        {
            // Handles ArgumentException and its derived exceptions
            // if they were not already caught above.
            Console.WriteLine("Caught ArgumentException: " + ex.Message);
        }
        catch (Exception ex)
        {
            // General exception handler.
            Console.WriteLine("Caught Exception: " + ex.Message);
        }



        // TEST 3: Valid input

        Console.WriteLine();
        Console.WriteLine("-- ParseAge(\"30\") --");

        try
        {
            int result = AgeParser.ParseAge("30");

            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught Exception: " + ex.Message);
        }


        Console.ReadLine();
    }
}