using System;

// Class used to demonstrate the finally block
class FinallyBlock
{
    // Method that runs the finally block example
    public static void Run()
    {
        // Numerator array contains 8 elements
        int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };

        // Denominator array contains only 6 elements
        // It also contains 0 values
        int[] denom = { 2, 0, 4, 4, 0, 8 };

        // Loop through the numerator array
        for (int i = 0; i < numer.Length; i++)
        {
            try
            {
                // Divide numerator by denominator
                Console.WriteLine(
                    numer[i] + " / " + denom[i] + " = " +
                    (numer[i] / denom[i])
                );
            }

            // Handles division by zero
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            }

            // Handles invalid array index
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("No matching element found.");
            }

            // Finally always executes
            // It executes whether an exception occurs or not
            finally
            {
                Console.WriteLine("Finally Block");
            }
        }
    }
}