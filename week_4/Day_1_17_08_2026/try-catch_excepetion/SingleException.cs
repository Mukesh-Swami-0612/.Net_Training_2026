using System;

// Class used to demonstrate a single catch statement
class SingleException
{
    // Run() method contains the single exception example
    public static void Run()
    {
        // Create an array containing numerator values
        int[] numer = { 4, 8, 16, 32, 64, 128 };

        // Create an array containing denominator values
        // Notice that some values are 0
        int[] denom = { 2, 0, 4, 4, 0, 8 };

        // Loop through all elements of the numerator array
        for (int i = 0; i < numer.Length; i++)
        {
            // Code that may generate an exception goes inside try
            try
            {
                // Perform division and display the result
                // If denom[i] is 0, DivideByZeroException occurs
                Console.WriteLine(
                    numer[i] + " / " + denom[i] + " = " +
                    (numer[i] / denom[i])
                );
            }

            // Catch and handle DivideByZeroException
            catch (DivideByZeroException)
            {
                // Display message when division by zero occurs
                Console.WriteLine("Can't divide by zero!");
            }
        }
    }
}