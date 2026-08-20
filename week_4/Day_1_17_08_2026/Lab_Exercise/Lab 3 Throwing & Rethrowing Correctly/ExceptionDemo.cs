using System;

class ExceptionDemo
{
    // ---------------------------------------------------------
    // Divides two numbers.
    // Throws DivideByZeroException if b is zero.
    // ---------------------------------------------------------

    public static int DivideInternal(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException(
                "Cannot divide by zero in DivideInternal");
        }

        return a / b;
    }


    // ---------------------------------------------------------
    // Calls DivideInternal and rethrows using throw;
    // This preserves the original stack trace.
    // ---------------------------------------------------------

    public static int CallSiteGood(int a, int b)
    {
        try
        {
            return DivideInternal(a, b);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("[Good] Logging before rethrow...");

            // Correct way to rethrow an exception.
            // Original stack trace is preserved.
            throw;
        }
    }


    // ---------------------------------------------------------
    // Calls DivideInternal and rethrows using throw ex;
    // This resets the stack trace.
    // ---------------------------------------------------------

    public static int CallSiteBad(int a, int b)
    {
        try
        {
            return DivideInternal(a, b);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("[Bad] Logging before rethrow...");

            // This rethrows the exception but resets
            // the stack trace from this location.
            throw ex;
        }
    }
}