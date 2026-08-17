using System.Linq;

namespace Lab5;

public class Program
{
    public static void Main()
    {
        // Raw multi-line log data.
        string rawLog = """
2026-08-14 09:15:00 INFO Service started
2026-08-14 09:16:12 WARN Disk usage high
2026-08-14 09:17:45 ERROR Request failed code=404
2026-08-14 09:18:03 INFO Request completed
2026-08-14 09:19:22 ERROR Upstream error code=500
2026-08-14 09:20:00 INFO Shutdown complete
""";

        // Parse the raw log into LogEntry objects.
        List<LogEntry> entries = LogParser.ParseLog(rawLog);

        // Print the total number of parsed entries.
        Console.WriteLine($"Parsed {entries.Count} entries.");
        Console.WriteLine();

        // Use LINQ to count entries grouped by log level.
        var summary = entries
            .GroupBy(entry => entry.Level)
            .Select(group => $"{group.Key}: {group.Count()}");

        // Print the summary.
        Console.WriteLine($"Summary: {string.Join(", ", summary)}");
        Console.WriteLine();

        // Print all parsed entries.
        Console.WriteLine("--- Parsed entries ---");

        foreach (LogEntry entry in entries)
        {
            Console.WriteLine(
                $"{entry.Date} {entry.Time} {entry.Level} {entry.Message}"
            );
        }

        Console.WriteLine();

        // Redact error codes from ERROR lines.
        string redactedLog = LogParser.RedactErrorCodes(rawLog);

        // Print the redacted log.
        Console.WriteLine("--- Redacted log ---");
        Console.WriteLine(redactedLog);
    }
}