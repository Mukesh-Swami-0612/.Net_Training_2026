using System;

public class LogEntry
{
    // Stores the time when the log was created
    public DateTime Timestamp { get; set; }

    // Stores the log level such as INFO, WARNING, or ERROR
    public string LogLevel { get; set; }

    // Stores the actual log message
    public string Message { get; set; }

    // Stores exception information if available
    public string Exception { get; set; }

    /// <summary>
    /// Creates a new LogEntry object.
    /// </summary>
    public LogEntry(DateTime timestamp, string logLevel, string message, string exception = "")
    {
        Timestamp = timestamp;
        LogLevel = logLevel;
        Message = message;
        Exception = exception;
    }
}