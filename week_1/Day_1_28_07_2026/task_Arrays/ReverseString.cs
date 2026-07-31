using System;

public class ReverseString
{
    public static void Reverse(string str)
    {
        Console.Write("Reversed String: ");

        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }

        Console.WriteLine();
    }
}