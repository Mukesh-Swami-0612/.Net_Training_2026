using System;
using System.Collections.Generic;

// Demonstrates and tests MyDictionary.
class Program
{
    // Entry point of the application.
    static void Main()
    {
        Console.WriteLine("=== Lab 6: MyDictionary<TKey, TValue> ===");
        Console.WriteLine();

        // Create our custom dictionary with only 5 buckets.
        // Using a small number of buckets makes collisions more likely.
        MyDictionary<string, int> myDictionary =
            new MyDictionary<string, int>(5);

        // Create the real Dictionary for comparison.
        Dictionary<string, int> builtInDictionary =
            new Dictionary<string, int>();

        // Store more than 20 key/value pairs.
        string[] keys =
        {
            "Apple",
            "Banana",
            "Orange",
            "Mango",
            "Grapes",
            "Pineapple",
            "Watermelon",
            "Strawberry",
            "Blueberry",
            "Papaya",
            "Guava",
            "Peach",
            "Pear",
            "Kiwi",
            "Cherry",
            "Lemon",
            "Lime",
            "Coconut",
            "Avocado",
            "Melon",
            "Plum",
            "Apricot"
        };

        // Add the same data to both dictionaries.
        for (int i = 0; i < keys.Length; i++)
        {
            myDictionary.Add(keys[i], i + 1);
            builtInDictionary.Add(keys[i], i + 1);
        }

        Console.WriteLine("20+ key/value pairs added.");
        Console.WriteLine();

        // Verify every key against the built-in Dictionary.
        bool allCorrect = true;

        foreach (string key in keys)
        {
            bool myFound = myDictionary.TryGetValue(
                key,
                out int myValue);

            bool builtInFound = builtInDictionary.TryGetValue(
                key,
                out int builtInValue);

            // Compare both dictionaries.
            if (!myFound ||
                !builtInFound ||
                myValue != builtInValue)
            {
                allCorrect = false;

                Console.WriteLine(
                    $"ERROR: {key} -> MyDictionary={myValue}, " +
                    $"Dictionary={builtInValue}");
            }
        }

        Console.WriteLine(
            $"Correctness check: {(allCorrect ? "PASSED" : "FAILED")}");

        Console.WriteLine();

        // Demonstrate indexer getter.
        Console.WriteLine(
            $"myDictionary[\"Mango\"] = {myDictionary["Mango"]}");

        Console.WriteLine();

        // Demonstrate indexer setter.
        // This updates the existing value.
        myDictionary["Mango"] = 999;

        Console.WriteLine(
            $"After update, myDictionary[\"Mango\"] = " +
            $"{myDictionary["Mango"]}");

        Console.WriteLine();

        // Demonstrate collection-initializer-style index syntax.
        // The indexer setter makes this syntax possible.
        MyDictionary<string, int> initializedDictionary =
            new MyDictionary<string, int>
            {
                ["One"] = 1,
                ["Two"] = 2,
                ["Three"] = 3,
                ["Four"] = 4
            };

        Console.WriteLine("Index initializer demonstration:");

        Console.WriteLine(
            $"One = {initializedDictionary["One"]}");

        Console.WriteLine(
            $"Two = {initializedDictionary["Two"]}");

        Console.WriteLine(
            $"Three = {initializedDictionary["Three"]}");

        Console.WriteLine(
            $"Four = {initializedDictionary["Four"]}");

        Console.WriteLine();

        // Demonstrate TryGetValue for a missing key.
        if (myDictionary.TryGetValue("NotFound", out int missingValue))
        {
            Console.WriteLine(
                $"NotFound = {missingValue}");
        }
        else
        {
            Console.WriteLine(
                "TryGetValue correctly returned false for missing key.");
        }

        Console.WriteLine();

        // Demonstrate indexer getter throwing KeyNotFoundException.
        try
        {
            int value = myDictionary["NotFound"];
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine(
                "Indexer correctly threw KeyNotFoundException.");
        }

        Console.WriteLine();

        // Demonstrate IEnumerable by using foreach.
        Console.WriteLine("All entries in MyDictionary:");

        foreach (KeyValuePair<string, int> item in myDictionary)
        {
            Console.WriteLine(
                $"{item.Key} -> {item.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("Lab completed.");
    }
}