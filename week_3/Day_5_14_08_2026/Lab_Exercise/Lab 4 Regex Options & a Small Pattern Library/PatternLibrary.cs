using System.Text.RegularExpressions;

// This class stores reusable regular expression patterns.
public static class PatternLibrary
{
    // Email pattern.
    // Example: a@b.com
    public static readonly Regex Email = new Regex(
        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
        RegexOptions.Compiled
    );

    // US phone number pattern.
    // Example: 555-123-4567
    public static readonly Regex UsPhone = new Regex(
        @"^\d{3}-\d{3}-\d{4}$",
        RegexOptions.Compiled
    );

    // Hexadecimal color pattern.
    // Example: #1A2B3C
    public static readonly Regex HexColor = new Regex(
        @"^#[0-9A-Fa-f]{6}$",
        RegexOptions.Compiled
    );

    // Checks whether the given string is a valid email.
    public static bool IsValidEmail(string input)
    {
        return Email.IsMatch(input);
    }

    // Checks whether the given string is a valid US phone number.
    public static bool IsValidPhone(string input)
    {
        return UsPhone.IsMatch(input);
    }

    // Checks whether the given string is a valid hexadecimal color.
    public static bool IsValidHexColor(string input)
    {
        return HexColor.IsMatch(input);
    }
}