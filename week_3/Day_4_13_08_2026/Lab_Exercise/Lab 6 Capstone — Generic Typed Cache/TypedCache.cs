using System;
using System.Collections.Generic;

public class TypedCache<TKey, TValue> where TKey : notnull
{
    private readonly Dictionary<TKey, TValue> _store = new();

    private static int _totalInstances;

    public TypedCache()
    {
        _totalInstances++;
    }

    public TValue this[TKey key]
    {
        get
        {
            if (!_store.TryGetValue(key, out TValue? value))
            {
                throw new KeyNotFoundException(
                    $"The given key '{key}' was not present in the cache.");
            }

            return value;
        }
        set
        {
            _store[key] = value;
        }
    }

    public int Count => _store.Count;

    public static int TotalCacheInstances => _totalInstances;

    public static void PrintGlobalStats()
    {
        Console.WriteLine(
            $"Global TypedCache<{typeof(TKey).Name},{typeof(TValue).Name}> instances created: {_totalInstances}");
    }

    public void Add(
        TKey key,
        TValue value,
        CacheEntryOptions? options = null)
    {
        _store[key] = value;

        if (options != null)
        {
            Console.WriteLine(
                $"Added key '{key}' with Label='{options.Label}', Pinned={options.Pinned}");
        }
    }
}