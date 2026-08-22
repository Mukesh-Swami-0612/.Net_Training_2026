using System;

namespace Lab4_GenericDelegates
{
    // Logger class contains functionality related to logging messages.
    class Logger
    {
        // Logs a message with the current date and time.
        public static void Log(string message)
        {
            Console.WriteLine(
                $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}"
            );
        }
    }
}