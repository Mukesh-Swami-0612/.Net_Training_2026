using System;

public static class StringUtils
{
    public static bool IsPalindrome(string s)
    {
        string reversed = Reverse(s);

        return s == reversed;
    }

    public static string Reverse(string s)
    {
        char[] characters = s.ToCharArray();

        Array.Reverse(characters);

        return new string(characters);
    }

    public static int WordCount(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}