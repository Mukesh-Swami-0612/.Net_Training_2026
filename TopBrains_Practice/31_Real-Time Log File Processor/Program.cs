using System;

public class Program
{
    /// <summary>
    /// Main method where the application starts.
    /// </summary>
    public static void Main()
    {
        // Buffer will flush automatically after 3 logs
        LogProcessor processor = new LogProcessor(
            3,
            "application.log"
        );

        // Create and process INFO log
        LogEntry log1 = new LogEntry(
            DateTime.Now,
            "INFO",
            "Application started."
        );

        processor.ProcessLog(log1);

        // Create and process another INFO log
        LogEntry log2 = new LogEntry(
            DateTime.Now,
            "INFO",
            "User logged in."
        );

        processor.ProcessLog(log2);

        // Create and process ERROR log
        LogEntry log3 = new LogEntry(
            DateTime.Now,
            "ERROR",
            "Database connection failed.",
            "SQL connection timeout."
        );

        processor.ProcessLog(log3);

        // The buffer automatically flushes here
        // because the capacity is 3

        // Add another WARNING log
        LogEntry log4 = new LogEntry(
            DateTime.Now,
            "WARNING",
            "Memory usage is high."
        );

        processor.ProcessLog(log4);

        // Add another ERROR log
        LogEntry log5 = new LogEntry(
            DateTime.Now,
            "ERROR",
            "Unable to load user data.",
            "UserNotFoundException"
        );

        processor.ProcessLog(log5);

        // Flush remaining logs
        processor.CompleteProcessing();

        // Display all ERROR logs
        processor.DisplayErrorSummary();

        Console.WriteLine("\nLog processing completed.");
    }
}