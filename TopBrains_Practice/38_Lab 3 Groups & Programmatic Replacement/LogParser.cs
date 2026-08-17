using System;
using System.Text.RegularExpressions;

public class LogParser
{
    // Parses a log line and prints date, time, level, and message.
    public static void ParseLogLine()
    {
        string logLine =
            "2026-08-14 09:15:32 ERROR Connection timed out";

        // Named groups:
        // date    -> 2026-08-14
        // time    -> 09:15:32
        // level   -> ERROR
        // message -> Connection timed out
        string pattern =
            @"^(?<date>\d{4}-\d{2}-\d{2})\s+" +
            @"(?<time>\d{2}:\d{2}:\d{2})\s+" +
            @"(?<level>\w+)\s+" +
            @"(?<message>.+)$";

        Match match = Regex.Match(logLine, pattern);

        if (match.Success)
        {
            Console.WriteLine(
                $"date={match.Groups["date"].Value}, " +
                $"time={match.Groups["time"].Value}, " +
                $"level={match.Groups["level"].Value}, " +
                $"message={match.Groups["message"].Value}"
            );
        }
    }
}