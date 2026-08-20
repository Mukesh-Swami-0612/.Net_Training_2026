using System;

// Class used to demonstrate the throw statement
class ThrowException
{
    // Method that runs the throw exception example
    public static void Run()
    {
        // Store a person's age
        int age = 15;

        try
        {
            // Check if age is less than 18
            if (age < 18)
            {
                // Manually throw an exception
                throw new Exception("Age must be 18 or above.");
            }

            // This will execute only when age is 18 or above
            Console.WriteLine("Person is eligible.");
        }

        // Catch the exception created using throw
        catch (Exception ex)
        {
            // Display the exception message
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
}