using System;
using System.Text.RegularExpressions;

public class KeyValueParser
{
    // Finds and prints every key/value pair from the input.
    public static void ParsePairs()
    {
        string kvText = "name=Alice;age=30;city=NYC";

        // Named groups:
        // key   -> name
        // value -> Alice
        //
        // Then the same pattern repeats for age=30 and city=NYC.
        string pattern =
            @"(?<key>[^=;]+)=(?<value>[^;]+)";

        MatchCollection matches = Regex.Matches(kvText, pattern);

        foreach (Match match in matches)
        {
            string key = match.Groups["key"].Value;
            string value = match.Groups["value"].Value;

            Console.WriteLine($"{key}={value}");
        }
    }
}