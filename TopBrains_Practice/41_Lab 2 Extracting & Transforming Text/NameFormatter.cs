
using System.Text.RegularExpressions;

// NameFormatter class.
// Summary: Converts "lastname, firstname" into "firstname lastname".
public static class NameFormatter
{
    // FormatName function.
    // Summary: Uses Regex.Replace and capturing groups to rearrange the name.
    public static string FormatName(string name)
    {
        // Group 1 = lastname
        // Group 2 = firstname
        string pattern = @"^\s*(\w+)\s*,\s*(\w+)\s*$";

        // $2 = firstname
        // $1 = lastname
        string replacement = "$2 $1";

        return Regex.Replace(name, pattern, replacement);
    }
}
