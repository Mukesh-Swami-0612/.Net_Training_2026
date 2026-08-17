
using System.Text.RegularExpressions;

// CardMasker class.
// Summary: Finds credit-card-like numbers and hides all digits except the last four.
public static class CardMasker
{
    // MaskCard function.
    // Summary: Replaces the first 12 digits of a 16-digit card number with X.
    public static string MaskCard(string text)
    {
        // Pattern:
        // \b              -> word boundary
        // (\d{4})         -> first four digits
        // ([- ]?)         -> optional dash or space
        // (\d{4})         -> second four digits
        // ([- ]?)         -> optional dash or space
        // (\d{4})         -> third four digits
        // ([- ]?)         -> optional dash or space
        // (\d{4})         -> final four digits
        string pattern = @"\b\d{4}([- ]?)\d{4}\1\d{4}\1\d{4}\b";

        // Replacement keeps the separators
        // and replaces the first 12 digits with X.
        string replacement = "XXXX$1XXXX$1XXXX$1$2";

        Match match = Regex.Match(text, pattern);

        if (!match.Success)
        {
            return text;
        }

        string cardNumber = match.Value;

        // Get the separators used in the card number.
        string separator = match.Groups[1].Value;

        // Get the final four digits.
        string lastFour = cardNumber.Substring(cardNumber.Length - 4);

        // Create masked card.
        string masked =
            "XXXX" + separator +
            "XXXX" + separator +
            "XXXX" + separator +
            lastFour;

        // Replace the original card number.
        return Regex.Replace(text, pattern, masked);
    }
}

