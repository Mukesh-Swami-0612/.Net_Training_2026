
using System.Collections.Generic;
using System.Text.RegularExpressions;

// OrderExtractor class.
// Summary: Finds order numbers from unstructured text.
public static class OrderExtractor
{
    // ExtractOrders function.
    // Summary: Finds every order number and returns only the numeric part.
    public static List<string> ExtractOrders(string text)
    {
        List<string> orderNumbers = new List<string>();

        // Pattern:
        // Order      -> matches the word "Order"
        // \s*        -> allows zero or more spaces
        // #          -> matches the # symbol
        // (\d+)      -> capturing group containing one or more digits
        string pattern = @"Order\s*#(\d+)";

        // Find every matching order.
        MatchCollection matches =
            Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        // Go through every match.
        foreach (Match match in matches)
        {
            // Groups[1] contains only the number.
            orderNumbers.Add(match.Groups[1].Value);
        }

        return orderNumbers;
    }
}
