using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class LogProcessor
{
    // StringBuilder stores formatted logs temporarily
    private StringBuilder logBuffer = new StringBuilder();

    // Stores error logs separately
    private List<LogEntry> errorLogs = new List<LogEntry>();

    // Maximum number of logs allowed in the buffer
    private int bufferCapacity;

    // Keeps track of how many logs are currently in the buffer
    private int currentBufferCount = 0;

    // File where normal logs will be stored
    private string logFilePath;

    /// <summary>
    /// Creates a LogProcessor with the given buffer capacity and file path.
    /// </summary>
    public LogProcessor(int bufferCapacity, string logFilePath)
    {
        this.bufferCapacity = bufferCapacity;
        this.logFilePath = logFilePath;

        // Create or clear the log file when processor starts
        File.WriteAllText(logFilePath, string.Empty);
    }

    /// <summary>
    /// Processes a single log entry and adds it to the buffer.
    /// </summary>
    public void ProcessLog(LogEntry logEntry)
    {
        // Build the log message using StringBuilder
        logBuffer.AppendLine(FormatLog(logEntry));

        // Increase the number of logs in the buffer
        currentBufferCount++;

        // Store ERROR logs separately
        if (logEntry.LogLevel.Equals("ERROR", StringComparison.OrdinalIgnoreCase))
        {
            errorLogs.Add(logEntry);
        }

        // Flush the buffer when it reaches its capacity
        if (currentBufferCount >= bufferCapacity)
        {
            FlushBuffer();
        }
    }

    /// <summary>
    /// Formats a LogEntry into a readable log message.
    /// </summary>
    private string FormatLog(LogEntry logEntry)
    {
        StringBuilder formattedLog = new StringBuilder();

        formattedLog.Append($"[{logEntry.Timestamp:yyyy-MM-dd HH:mm:ss}] ");
        formattedLog.Append($"[{logEntry.LogLevel}] ");
        formattedLog.Append(logEntry.Message);

        // Add exception information if it exists
        if (!string.IsNullOrEmpty(logEntry.Exception))
        {
            formattedLog.Append($" | Exception: {logEntry.Exception}");
        }

        return formattedLog.ToString();
    }

    /// <summary>
    /// Writes the buffered log messages to the log file.
    /// </summary>
    public void FlushBuffer()
    {
        // Do nothing if there are no logs in the buffer
        if (currentBufferCount == 0)
        {
            return;
        }

        // Append the entire buffer to the file at once
        File.AppendAllText(logFilePath, logBuffer.ToString());

        // Clear the buffer after writing
        logBuffer.Clear();

        // Reset the buffer count
        currentBufferCount = 0;

        Console.WriteLine("Buffer flushed to file.");
    }

    /// <summary>
    /// Displays a summary of all ERROR logs.
    /// </summary>
    public void DisplayErrorSummary()
    {
        Console.WriteLine("\n===== ERROR SUMMARY =====");

        // Check whether any errors were found
        if (errorLogs.Count == 0)
        {
            Console.WriteLine("No error logs found.");
            return;
        }

        Console.WriteLine($"Total Errors: {errorLogs.Count}");

        // Display each error
        foreach (LogEntry error in errorLogs)
        {
            Console.WriteLine(
                $"{error.Timestamp:yyyy-MM-dd HH:mm:ss} - {error.Message}"
            );

            // Display exception if available
            if (!string.IsNullOrEmpty(error.Exception))
            {
                Console.WriteLine($"Exception: {error.Exception}");
            }
        }
    }

    /// <summary>
    /// Flushes any remaining logs that are still in the buffer.
    /// </summary>
    public void CompleteProcessing()
    {
        // Flush remaining logs before the application ends
        FlushBuffer();
    }
}