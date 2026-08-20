using System;

// User-defined exception class
// It inherits from the built-in Exception class
class MyException : Exception
{
    // Constructor receives the error message
    public MyException(string message)
        : base(message)
    {
    }
}

// Class used to demonstrate a user-defined exception
class UserDefinedException
{
    // Method that runs the user-defined exception example
    public static void Run()
    {
        // Declare two integer values
        int a = 50;
        int b = 10;

        // Perform division
        int k = a / b;

        try
        {
            // Check whether the value of k is less than 10
            if (k < 10)
            {
                // Manually throw our custom exception
                throw new MyException("Value of k is less than 10.");
            }

            // This executes when k is 10 or greater
            Console.WriteLine("Value of k is: " + k);
        }

        // Catch our user-defined exception
        catch (MyException e)
        {
            // Display a message showing that custom exception was caught
            Console.WriteLine("Caught My Exception");

            // Display the message passed to MyException
            Console.WriteLine(e.Message);
        }
    }
}