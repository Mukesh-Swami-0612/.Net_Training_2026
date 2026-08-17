using System;

public class Lab3
{
    // Run() executes all four Regex demonstrations.
    public void Run()
    {
        Console.WriteLine("===== LAB 3: GROUPS & PROGRAMMATIC REPLACEMENT =====");

        Console.WriteLine("\n--- Task 1: Named Groups ---");
        LogParser.ParseLogLine();

        Console.WriteLine("\n--- Task 2: Key/Value Pairs ---");
        KeyValueParser.ParsePairs();

        Console.WriteLine("\n--- Task 3: Number Formatting ---");
        TextTransformer.FormatNumbers();

        Console.WriteLine("\n--- Task 4: ALL CAPS to Title Case ---");
        TextTransformer.ConvertAllCapsWords();
    }
}