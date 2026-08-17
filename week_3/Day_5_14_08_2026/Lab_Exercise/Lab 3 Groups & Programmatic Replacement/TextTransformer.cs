using System;
using System.Globalization;
using System.Text.RegularExpressions;

public class TextTransformer
{
    // Finds whole numbers and adds thousands separators.
    public static void FormatNumbers()
    {
        string numbers = "Revenue: 1234567, Costs: 89000";

        string pattern = @"\b\d+\b";

        string result = Regex.Replace(
            numbers,
            pattern,
            match =>
            {
                long number = long.Parse(
                    match.Value,
                    CultureInfo.InvariantCulture
                );

                return number.ToString(
                    "N0",
                    CultureInfo.InvariantCulture
                );
            }
        );

        Console.WriteLine(result);
    }


    // Finds ALL CAPS words with at least two letters
    // and converts them to Title Case.
    public static void ConvertAllCapsWords()
    {
        string shouting = "THIS IS URGENT please respond";

        string pattern = @"\b[A-Z]{2,}\b";

        string result = Regex.Replace(
            shouting,
            pattern,
            match =>
            {
                string word = match.Value.ToLowerInvariant();

                return char.ToUpper(word[0]) + word.Substring(1);
            }
        );

        Console.WriteLine(result);
    }
}