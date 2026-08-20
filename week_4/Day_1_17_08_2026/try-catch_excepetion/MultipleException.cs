using System;

// Class used to demonstrate multiple catch statements
class MultipleException
{
    // Run() method contains the multiple exception example
    public static void Run()
    {
        // Create numerator array
        // This array contains 8 elements
        int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };

        // Create denominator array
        // This array contains only 6 elements
        // It also contains zero values
        int[] denom = { 2, 0, 4, 4, 0, 8 };

        // Loop through all elements of the numerator array
        for (int i = 0; i < numer.Length; i++)
        {
            // Code that may generate an exception
            try
            {
                // Perform division and display the result
                // DivideByZeroException can occur if denom[i] is 0
                // IndexOutOfRangeException can occur if denom[i] doesn't exist
                Console.WriteLine(
                    numer[i] + " / " + denom[i] + " = " +
                    (numer[i] / denom[i])
                );
            }

            // First catch handles division by zero
            catch (DivideByZeroException)
            {
                // Display message when denominator is zero
                Console.WriteLine("Can't divide by zero!");
            }

            // Second catch handles an invalid array index
            catch (IndexOutOfRangeException)
            {
                // Display message when denom[i] is outside the array
                Console.WriteLine("No matching element found.");
            }
        }
    }
}