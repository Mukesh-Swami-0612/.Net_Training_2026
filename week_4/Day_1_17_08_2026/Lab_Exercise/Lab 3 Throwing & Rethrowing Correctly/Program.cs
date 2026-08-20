using System;

class Program
{
    static void Main(string[] args)
    {
        // Demonstrating throw; - correct way to rethrow

        try
        {
            ExceptionDemo.CallSiteGood(10, 0);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Good stack trace mentions DivideInternal: " +
                              ex.StackTrace.Contains("DivideInternal"));

            Console.WriteLine();
            Console.WriteLine("Good Stack Trace:");
            Console.WriteLine(ex.StackTrace);
        }


        // Demonstrating throw ex; - resets stack trace

        try
        {
            ExceptionDemo.CallSiteBad(10, 0);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Bad stack trace mentions DivideInternal: " +
                              ex.StackTrace.Contains("DivideInternal"));

            Console.WriteLine();
            Console.WriteLine("Bad Stack Trace:");
            Console.WriteLine(ex.StackTrace);
        }


        // Demonstrating throwing a new exception

        try
        {
            ValidationDemo.Validate(-5);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine();
            Console.WriteLine("Validate(-5) threw: " + ex.Message);
        }
    }
}