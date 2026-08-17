namespace Lab5;

public class LogEntry
{
    // Stores the date portion of the log.
    public string Date { get; init; } = string.Empty;

    // Stores the time portion of the log.
    public string Time { get; init; } = string.Empty;

    // Stores the log level such as INFO, WARN, or ERROR.
    public string Level { get; init; } = string.Empty;

    // Stores the actual message.
    public string Message { get; init; } = string.Empty;
}