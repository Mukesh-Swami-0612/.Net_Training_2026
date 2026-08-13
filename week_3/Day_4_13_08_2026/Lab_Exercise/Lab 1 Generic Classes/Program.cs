using System;

public class Program
{
    public static void Main()
    {
        // Box<int>
        Box<int> intBox = new Box<int>(42);

        Console.WriteLine($"Box<int>: {intBox.GetValue()}");


        // Box<string>
        Box<string> stringBox = new Box<string>("Hello");

        Console.WriteLine($"Box<string>: {stringBox.GetValue()}");


        // Box<DateTime>
        Box<DateTime> dateBox = new Box<DateTime>(
            new DateTime(2026, 8, 12)
        );

        Console.WriteLine(
            $"Box<DateTime>: {dateBox.GetValue():yyyy-MM-dd}"
        );


        // Replace example
        intBox.Replace(100);

        Console.WriteLine(
            $"Box<int> after Replace: {intBox.GetValue()}"
        );


        // CreateEmpty<T>()
        Box<int> emptyIntBox = Box<int>.CreateEmpty<int>();

        Console.WriteLine(
            $"Empty Box<int>: {emptyIntBox.GetValue()}"
        );


        // Pair<string, int>
        Pair<string, int> agePair = new Pair<string, int>(
            "Age",
            30
        );

        Console.WriteLine($"Pair: {agePair}");


        // SortedBox<int>
        SortedBox<int> sortedBox = new SortedBox<int>();

        sortedBox.Add(5);
        sortedBox.Add(1);
        sortedBox.Add(3);

        Console.WriteLine(
            $"SortedBox after adding 5, 1, 3: " +
            $"{string.Join(", ", sortedBox.GetItems())}"
        );
    }
}