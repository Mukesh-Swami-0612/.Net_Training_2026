using System;

class ExceptionHelper
{
    // Prints all exceptions in the InnerException chain.
    public static void PrintExceptionChain(Exception ex)
    {
        // Start from the outer exception.
        Exception current = ex;

        // Keeps track of the current exception depth.
        int depth = 0;

        // Continue until there are no more exceptions.
        while (current != null)
        {
            // Create indentation based on the exception depth.
            string indent = new string(' ', depth * 2);

            // Print exception type and message.
            Console.WriteLine(
                indent +
                current.GetType().Name +
                ": " +
                current.Message
            );

            // Move to the next inner exception.
            current = current.InnerException;

            // Increase the depth.
            depth++;
        }
    }
}