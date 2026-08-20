using System;

class Program
{
    // Main method: starting point of the program.
    static void Main(string[] args)
    {
        try
        {
            // Calling the higher-level method.
            int timeout = ConfigService.GetTimeoutSetting();

            Console.WriteLine("Timeout: " + timeout);
        }
        catch (Exception ex)
        {
            // Printing the outer exception message.
            Console.WriteLine("Top-level: " + ex.Message);

            // Checking whether an inner exception exists.
            if (ex.InnerException != null)
            {
                Console.WriteLine("Caused by: " + ex.InnerException.Message);

                // Printing the runtime type of the inner exception.
                Console.WriteLine(
                    "Inner exception type: " +
                    ex.InnerException.GetType().Name
                );
            }

            Console.WriteLine();
            Console.WriteLine("-- PrintExceptionChain --");

            // Printing the complete exception chain.
            ExceptionHelper.PrintExceptionChain(ex);
        }

        Console.ReadLine();
    }
}