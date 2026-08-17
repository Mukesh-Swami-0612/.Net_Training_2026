using System.Text.RegularExpressions;

namespace Lab5;

public static class LogParser
{
    // Regex pattern for parsing each log line.
    // Named groups:
    // date    -> date
    // time    -> time
    // level   -> INFO, WARN, or ERROR
    // message -> remaining message
    private static readonly Regex LogRegex = new Regex(
        @"^(?<date>\d{4}-\d{2}-\d{2})\s+" +
        @"(?<time>\d{2}:\d{2}:\d{2})\s+" +
        @"(?<level>INFO|WARN|ERROR)\s+" +
        @"(?<message>.*)$",
        RegexOptions.Multiline
    );

    // Parses all log lines and converts them into LogEntry objects.
    public static List<LogEntry> ParseLog(string rawLog)
    {
        // Create a list to store parsed log entries.
        List<LogEntry> entries = new List<LogEntry>();

        // Find every matching log line.
        MatchCollection matches = LogRegex.Matches(rawLog);

        // Process every matched line.
        foreach (Match match in matches)
        {
            // Create a LogEntry using an object initializer.
            LogEntry entry = new LogEntry
            {
                Date = match.Groups["date"].Value,
                Time = match.Groups["time"].Value,
                Level = match.Groups["level"].Value,
                Message = match.Groups["message"].Value
            };

            // Add the object to the list.
            entries.Add(entry);
        }

        // Return all parsed entries.
        return entries;
    }

    // Redacts numeric error codes from ERROR lines.
    public static string RedactErrorCodes(string rawLog)
    {
        // This pattern matches complete ERROR lines.
        string errorLinePattern =
            @"^(?<line>\d{4}-\d{2}-\d{2}\s+" +
            @"\d{2}:\d{2}:\d{2}\s+" +
            @"ERROR\b.*)$";

        // MatchEvaluator processes each matched ERROR line.
        MatchEvaluator evaluator = match =>
        {
            // Get the complete ERROR line.
            string errorLine = match.Groups["line"].Value;

            // Replace every code=number with code=###.
            string redactedLine = Regex.Replace(
                errorLine,
                @"\bcode=\d+\b",
                "code=###"
            );

            // Return the updated ERROR line.
            return redactedLine;
        };

        // Apply the evaluator to every ERROR line.
        return Regex.Replace(
            rawLog,
            errorLinePattern,
            evaluator,
            RegexOptions.Multiline
        );
    }
}