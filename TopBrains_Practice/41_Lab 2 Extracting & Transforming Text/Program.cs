
using System;

// Main program class.
// Summary: Runs all four Regex demonstrations and displays the final output.
class Program
{
    // Main function.
    // Summary: Calls each helper class and prints the results.
    static void Main()
    {
        Console.WriteLine("=== Lab 2: Extracting & Transforming Text ===");
        Console.WriteLine();

        // -------------------------------------------------
        // 1. Extract order numbers
        // -------------------------------------------------

        string text =
            "Order #4521 was shipped. order   #99 is pending. ORDER #12345 was cancelled.";

        var orderNumbers = OrderExtractor.ExtractOrders(text);

        Console.WriteLine("Order numbers found: " +
                          string.Join(", ", orderNumbers));

        Console.WriteLine();


        // -------------------------------------------------
        // 2. Mask credit card number
        // -------------------------------------------------

        string cardText = "Card on file:   4111-1111-1111-1234";

        string maskedCard = CardMasker.MaskCard(cardText);

        Console.WriteLine("Masked card: " + maskedCard);

        Console.WriteLine();


        // -------------------------------------------------
        // 3. Reformat name
        // -------------------------------------------------

        string names = "Smith, John";

        string reformattedName = NameFormatter.FormatName(names);

        Console.WriteLine("Reformatted name: " + reformattedName);

        Console.WriteLine();


        // -------------------------------------------------
        // 4. Split tags
        // -------------------------------------------------

        string tags = "red, blue;green , yellow";

        string[] cleanTags = TagSplitter.SplitTags(tags);

        Console.WriteLine("Tags: [" +
                          string.Join(", ", cleanTags) +
                          "]");

        Console.WriteLine();
    }
}

