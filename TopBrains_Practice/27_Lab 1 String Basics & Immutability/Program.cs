using System;

class Lab1
{
    static void Main()
    {
        // Original
        string original = "  Hello, Training Team!  ";

        //Trim the string into a new variable
        string trimmed = original.Trim();

        //Compare original/trimmed
        Console.WriteLine(
            $"ReferenceEquals(original, trimmed): " +
            $"{object.ReferenceEquals(original, trimmed)}"
        );

        //Contains / StartsWith / IndexOf / Replace

        // Check whether the string contains "Training"
        Console.WriteLine(
            $"Contains \"Training\": {trimmed.Contains("Training")}"
        );

        // Check whether it starts with "Hello"
        Console.WriteLine(
            $"StartsWith trimmed \"Hello\": {trimmed.StartsWith("Hello")}"
        );

        // Find the index of the first comma
        Console.WriteLine(
            $"Index of first comma: {trimmed.IndexOf(',')}"
        );

        // Replace "Training Team" with "Engineering Team"
        string replaced = trimmed.Replace(
            "Training Team",
            "Engineering Team"
        );

        Console.WriteLine(
            $"\"Training Team\" replaced -> {replaced}"
        );

        //Split into words
        string[] words = trimmed.Split(
            new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        //IsNullOrWhiteSpace checks

        string nullString = null;
        string emptyString = "";
        string spacesString = "   ";
        string normalString = "ok";

        Console.WriteLine(
            $"IsNullOrWhiteSpace(null): " +
            $"{string.IsNullOrWhiteSpace(nullString)}"
        );

        Console.WriteLine(
            $"IsNullOrWhiteSpace(\"\"): " +
            $"{string.IsNullOrWhiteSpace(emptyString)}"
        );

        Console.WriteLine(
            $"IsNullOrWhiteSpace(\"   \"): " +
            $"{string.IsNullOrWhiteSpace(spacesString)}"
        );

        Console.WriteLine(
            $"IsNullOrWhiteSpace(\"ok\"): " +
            $"{string.IsNullOrWhiteSpace(normalString)}"
        );

        // Bonus Challenge
        string first = "HELLO";
        string second = "hello";

        int comparison = string.Compare(
            first,
            second,
            StringComparison.OrdinalIgnoreCase
        );

        Console.WriteLine(
            $"OrdinalIgnoreCase comparison: {comparison}"
        );
    }
}