
using System;
using System.Linq;
using System.Text.RegularExpressions;

// TagSplitter class.
// Summary: Splits a tag string using comma or semicolon separators and removes extra spaces.
public static class TagSplitter
{
    // SplitTags function.
    // Summary: Splits the tags and trims whitespace from every tag.
    public static string[] SplitTags(string tags)
    {
        // [,;] means:
        // Split wherever a comma OR semicolon is found.
        string[] parts = Regex.Split(tags, @"[,;]");

        // Remove leading/trailing spaces from each tag.
        string[] cleanTags = parts
            .Select(tag => tag.Trim())
            .Where(tag => tag.Length > 0)
            .ToArray();

        return cleanTags;
    }
}
