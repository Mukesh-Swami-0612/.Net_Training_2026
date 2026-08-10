using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

static class StringToolkit
{
    // 1. Reverse a string
    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();

        Array.Reverse(chars);

        return new string(chars);
    }

    // 2. Count a particular character
    public static int CountChar(string text, char searchChar)
    {
        int count = 0;

        foreach (char c in text)
        {
            if (c == searchChar)
            {
                count++;
            }
        }

        return count;
    }

    // 3. Remove duplicate characters
    public static string RemoveDuplicates(string input)
    {
        HashSet<char> seen = new HashSet<char>();
        StringBuilder result = new StringBuilder();

        foreach (char c in input)
        {
            if (seen.Add(c))
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }

    // 4. Check whether a string is a palindrome
    //    Ignores case and spaces
    public static bool IsPalindrome(string input)
    {
        string cleaned = input
            .Replace(" ", "")
            .ToLowerInvariant();

        string reversed = Reverse(cleaned);

        return cleaned == reversed;
    }

    // 5. Convert string to Title Case
    public static string ToTitleCase(string input)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        return textInfo.ToTitleCase(input);
    }

    // 6. Extract only digits
    public static string ExtractNumbers(string input)
    {
        StringBuilder numbers = new StringBuilder();

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                numbers.Append(c);
            }
        }

        return numbers.ToString();
    }

    // Bonus: Word frequency
    public static Dictionary<string, int> WordFrequency(string text)
    {
        Dictionary<string, int> frequency =
            new Dictionary<string, int>(
                StringComparer.OrdinalIgnoreCase
            );

        StringBuilder word = new StringBuilder();

        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                word.Append(c);
            }
            else if (word.Length > 0)
            {
                string currentWord = word.ToString();

                if (frequency.ContainsKey(currentWord))
                {
                    frequency[currentWord]++;
                }
                else
                {
                    frequency[currentWord] = 1;
                }

                word.Clear();
            }
        }

        // Handle the final word
        if (word.Length > 0)
        {
            string currentWord = word.ToString();

            if (frequency.ContainsKey(currentWord))
            {
                frequency[currentWord]++;
            }
            else
            {
                frequency[currentWord] = 1;
            }
        }

        return frequency;
    }
}


class Lab3
{
    static void Main()
    {
        // Reverse
        Console.WriteLine(
            $"Reverse(\"Hello\") -> \"{StringToolkit.Reverse("Hello")}\""
        );

        // CountChar
        Console.WriteLine(
            $"CountChar(\"banana\", 'a') -> {StringToolkit.CountChar("banana", 'a')}"
        );

        // RemoveDuplicates
        Console.WriteLine(
            $"RemoveDuplicates(\"mississippi\") -> \"{StringToolkit.RemoveDuplicates("mississippi")}\""
        );

        // IsPalindrome
        Console.WriteLine(
            $"IsPalindrome(\"race car\") -> {StringToolkit.IsPalindrome("race car")}"
        );

        // ToTitleCase
        Console.WriteLine(
            $"ToTitleCase(\"hello training team\") -> " +
            $"\"{StringToolkit.ToTitleCase("hello training team")}\""
        );

        // ExtractNumbers
        Console.WriteLine(
            $"ExtractNumbers(\"Order #4521, qty 3\") -> " +
            $"\"{StringToolkit.ExtractNumbers("Order #4521, qty 3")}\""
        );

        // Bonus
        Console.WriteLine();
        Console.WriteLine("Word Frequency:");

        string text = "Hello hello world! World world.";

        Dictionary<string, int> frequencies =
            StringToolkit.WordFrequency(text);

        foreach (var item in frequencies)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}