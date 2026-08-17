using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // PROGRAM 1: RegexOptions.IgnoreCase

        // Pattern is written in lowercase.
        string pattern = "hello";

        // Text is written in uppercase.
        string text = "HELLO";

        // Without IgnoreCase:
        // "hello" and "HELLO" are treated as different.
        bool withoutIgnoreCase = Regex.IsMatch(text, pattern);

        // With IgnoreCase:
        // "hello", "HELLO", "Hello", etc. are treated as the same.
        bool withIgnoreCase = Regex.IsMatch(
            text,
            pattern,
            RegexOptions.IgnoreCase
        );

        Console.WriteLine(
            $"IgnoreCase off: {withoutIgnoreCase}, " +
            $"IgnoreCase on: {withIgnoreCase}"
        );


        // PROGRAM 2: RegexOptions.Multiline

        // A string containing three separate lines.
        string multiLineText =
            "First line\n" +
            "Second line\n" +
            "Third line";

        // ^ means the beginning of the input.
        // Without Multiline, ^ only considers the beginning
        // of the complete string.
        MatchCollection withoutMultiline = Regex.Matches(
            multiLineText,
            "^"
        );

        // With Multiline, ^ considers the beginning
        // of every line.
        MatchCollection withMultiline = Regex.Matches(
            multiLineText,
            "^",
            RegexOptions.Multiline
        );

        Console.WriteLine(
            $"Line-start matches WITHOUT Multiline: " +
            $"{withoutMultiline.Count}"
        );

        Console.WriteLine(
            $"Line-start matches WITH Multiline: " +
            $"{withMultiline.Count}"
        );


        // PROGRAM 3: PatternLibrary - Email

        // Valid email.
        bool validEmail = PatternLibrary.IsValidEmail("a@b.com");

        // Invalid email.
        bool invalidEmail = PatternLibrary.IsValidEmail("not-an-email");

        Console.WriteLine(
            $"IsValidEmail(\"a@b.com\"): {validEmail}, " +
            $"IsValidEmail(\"not-an-email\"): {invalidEmail}"
        );


        // PROGRAM 4: PatternLibrary - US Phone

        // Valid phone because it follows:
        // 3 digits - 3 digits - 4 digits
        bool validPhone = PatternLibrary.IsValidPhone("555-123-4567");

        // Invalid phone because it does not contain hyphens.
        bool invalidPhone = PatternLibrary.IsValidPhone("5551234567");

        Console.WriteLine(
            $"IsValidPhone(\"555-123-4567\"): {validPhone}, " +
            $"IsValidPhone(\"5551234567\"): {invalidPhone}"
        );


        // PROGRAM 5: PatternLibrary - Hex Color

        // Valid hexadecimal color.
        bool validHex = PatternLibrary.IsValidHexColor("#1A2B3C");

        // Invalid because # is missing.
        bool invalidHex = PatternLibrary.IsValidHexColor("1A2B3C");

        Console.WriteLine(
            $"IsValidHexColor(\"#1A2B3C\"): {validHex}, " +
            $"IsValidHexColor(\"1A2B3C\"): {invalidHex}"
        );
    }
}