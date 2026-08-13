using System;

class Program
{
    static void Main()
    {
        // Create two TypedCache<string, int> instances
        var cache1 = new TypedCache<string, int>();
        var cache2 = new TypedCache<string, int>();

        // Add entries to cache1
        cache1.Add(
            "a",
            1,
            new CacheEntryOptions
            {
                Label = "First Number",
                Pinned = true
            });

        cache1.Add("b", 2);

        // Add entries to cache2
        cache2.Add(
            "x",
            10,
            new CacheEntryOptions
            {
                Label = "Ten",
                Pinned = false
            });

        cache2.Add("y", 20);

        // Read values using the indexer
        Console.WriteLine($"cache1[\"a\"] = {cache1["a"]}");

        // Display count
        Console.WriteLine($"cache1 Count: {cache1.Count}");

        // Try to access a missing key
        try
        {
            Console.WriteLine(cache1["z"]);
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine($"Missing key caught: {ex.Message}");
        }

        // Display global statistics
        TypedCache<string, int>.PrintGlobalStats();
    }
}