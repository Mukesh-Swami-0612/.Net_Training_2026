using System;
using System.Globalization;

static class StringToolkit
{
    // Converts a string into title case
    // Example:
    // "john smith" -> "John Smith"
    // "ravi KUMAR" -> "Ravi Kumar"
    public static string ToTitleCase(string text)
    {
        // Convert the text to lowercase first
        text = text.ToLower();

        // Convert the text to title case
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        return textInfo.ToTitleCase(text);
    }
}