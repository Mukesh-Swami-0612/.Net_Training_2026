using System;
using System.Text.RegularExpressions;

public class Lab1
{
    // Runs all five Regex exercises.
    public static void Run()
    {
        Console.WriteLine("===== LAB 1: Pattern-Writing Practice =====\n");

        ZipCodeTest();
        UsernameTest();
        HexColorTest();
        PasswordTest();
        SentenceTest();
    }


    // =========================================================
    // 1. ZIP CODE
    // =========================================================

    // Validates US ZIP codes in 5-digit or 5+4 format.
    private static void ZipCodeTest()
    {
        // ^          = beginning of string
        // \d{5}      = exactly 5 digits
        // (-\d{4})?  = optional - followed by exactly 4 digits
        // $          = end of string
        string pattern = @"^\d{5}(-\d{4})?$";

        string zip1 = "12345";
        string zip2 = "12345-6789";
        string zip3 = "1234";

        Console.WriteLine("----- ZIP Code -----");

        Console.WriteLine(
            $"ZIP \"{zip1}\": {Regex.IsMatch(zip1, pattern)}");

        Console.WriteLine(
            $"ZIP \"{zip2}\": {Regex.IsMatch(zip2, pattern)}");

        Console.WriteLine(
            $"ZIP \"{zip3}\": {Regex.IsMatch(zip3, pattern)}");

        Console.WriteLine();
    }


    // =========================================================
    // 2. USERNAME
    // =========================================================

    // Validates usernames with length and character restrictions.
    private static void UsernameTest()
    {
        // ^              = beginning
        // [A-Za-z_]      = first character must be letter or underscore
        // [A-Za-z0-9_]{2,15}
        //                = remaining 2 to 15 characters
        // $              = end
        //
        // Total length = 3 to 16 characters.
        string pattern = @"^[A-Za-z_][A-Za-z0-9_]{2,15}$";

        string username1 = "user_1";
        string username2 = "1user";
        string username3 = "ab";

        Console.WriteLine("----- Username -----");

        Console.WriteLine(
            $"Username \"{username1}\": {Regex.IsMatch(username1, pattern)}");

        Console.WriteLine(
            $"Username \"{username2}\": {Regex.IsMatch(username2, pattern)}");

        Console.WriteLine(
            $"Username \"{username3}\": {Regex.IsMatch(username3, pattern)}");

        Console.WriteLine();
    }


    // =========================================================
    // 3. HEX COLOR
    // =========================================================

    // Validates a simple #RRGGBB hexadecimal color.
    private static void HexColorTest()
    {
        // #            = literal # character
        // [0-9A-Fa-f]  = one hexadecimal character
        // {6}          = exactly 6 characters
        string pattern = @"^#[0-9A-Fa-f]{6}$";

        string color1 = "#1A2B3C";
        string color2 = "#GGGGGG";
        string color3 = "1A2B3C";

        Console.WriteLine("----- Hex Color -----");

        Console.WriteLine(
            $"Hex \"{color1}\": {Regex.IsMatch(color1, pattern)}");

        Console.WriteLine(
            $"Hex \"{color2}\": {Regex.IsMatch(color2, pattern)}");

        Console.WriteLine(
            $"Hex \"{color3}\": {Regex.IsMatch(color3, pattern)}");

        Console.WriteLine();
    }


    // =========================================================
    // 4. PASSWORD
    // =========================================================

    // Checks password length, uppercase letter, and digit.
    private static void PasswordTest()
    {
        // We intentionally use multiple Regex checks instead
        // of one large Regex pattern.
        //
        // This approach is easier to understand and maintain.

        string lengthPattern = @"^.{8,}$";

        // Checks whether at least one uppercase letter exists.
        string uppercasePattern = @"[A-Z]";

        // Checks whether at least one digit exists.
        string digitPattern = @"\d";

        string password1 = "password";
        string password2 = "Password1";
        string password3 = "pass1";

        Console.WriteLine("----- Password -----");

        Console.WriteLine(
            $"Password \"{password1}\": {IsStrongPassword(password1, lengthPattern, uppercasePattern, digitPattern)}");

        Console.WriteLine(
            $"Password \"{password2}\": {IsStrongPassword(password2, lengthPattern, uppercasePattern, digitPattern)}");

        Console.WriteLine(
            $"Password \"{password3}\": {IsStrongPassword(password3, lengthPattern, uppercasePattern, digitPattern)}");

        Console.WriteLine();
    }


    // Checks all three password requirements.
    private static bool IsStrongPassword(
        string password,
        string lengthPattern,
        string uppercasePattern,
        string digitPattern)
    {
        // Password must:
        // 1. Have at least 8 characters
        // 2. Contain an uppercase letter
        // 3. Contain a digit

        return Regex.IsMatch(password, lengthPattern)
            && Regex.IsMatch(password, uppercasePattern)
            && Regex.IsMatch(password, digitPattern);
    }


    // =========================================================
    // 5. SENTENCE
    // =========================================================

    // Validates a sentence ending with exactly one ., !, or ?.
    private static void SentenceTest()
    {
        // ^                    = beginning
        // [^.!?]+              = one or more characters except . ! ?
        // [.!?]                = exactly one ending punctuation mark
        // $                    = end
        string pattern = @"^[^.!?]+[.!?]$";

        string sentence1 = "Hello there.";
        string sentence2 = "Wait...";
        string sentence3 = "Really?";

        Console.WriteLine("----- Sentence -----");

        Console.WriteLine(
            $"Sentence \"{sentence1}\": {Regex.IsMatch(sentence1, pattern)}");

        Console.WriteLine(
            $"Sentence \"{sentence2}\": {Regex.IsMatch(sentence2, pattern)}");

        Console.WriteLine(
            $"Sentence \"{sentence3}\": {Regex.IsMatch(sentence3, pattern)}");

        Console.WriteLine();
    }
}