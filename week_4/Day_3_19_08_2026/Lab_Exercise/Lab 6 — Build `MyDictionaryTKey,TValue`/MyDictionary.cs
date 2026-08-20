using System;
using System.Collections;
using System.Collections.Generic;

// Represents a simplified generic dictionary using a chained hash table.
public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    where TKey : notnull
{
    // Represents one key/value pair stored inside a bucket.
    private class Entry
    {
        public TKey Key { get; }
        public TValue Value { get; set; }

        public Entry(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }

    // Small bucket count is intentionally used to demonstrate hash collisions.
    private readonly List<Entry>[] _buckets;

    // Creates the dictionary with the specified number of buckets.
    public MyDictionary(int bucketCount = 5)
    {
        if (bucketCount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(bucketCount));
        }

        _buckets = new List<Entry>[bucketCount];

        // Create a list for every bucket.
        for (int i = 0; i < _buckets.Length; i++)
        {
            _buckets[i] = new List<Entry>();
        }
    }

    // Adds a new key/value pair or updates the value if the key already exists.
    public void Add(TKey key, TValue value)
    {
        int bucketIndex = GetBucketIndex(key);

        // Check whether the key already exists.
        foreach (Entry entry in _buckets[bucketIndex])
        {
            if (EqualityComparer<TKey>.Default.Equals(entry.Key, key))
            {
                entry.Value = value;
                return;
            }
        }

        // Add a new entry to the bucket.
        _buckets[bucketIndex].Add(new Entry(key, value));
    }

    // Allows dictionary-style assignment such as dictionary["A"] = 100.
    public TValue this[TKey key]
    {
        get
        {
            // Try to find the requested value.
            if (TryGetValue(key, out TValue? value))
            {
                return value!;
            }

            // Throw the required exception when the key does not exist.
            throw new KeyNotFoundException(
                $"The key '{key}' was not found.");
        }

        set
        {
            // Add the key/value pair or update the existing value.
            Add(key, value);
        }
    }

    // Attempts to find a value for the specified key.
    public bool TryGetValue(TKey key, out TValue value)
    {
        int bucketIndex = GetBucketIndex(key);

        // Search only the bucket where the key should exist.
        foreach (Entry entry in _buckets[bucketIndex])
        {
            if (EqualityComparer<TKey>.Default.Equals(entry.Key, key))
            {
                value = entry.Value;
                return true;
            }
        }

        // Key was not found.
        value = default!;
        return false;
    }

    // Calculates which bucket should contain the specified key.
    private int GetBucketIndex(TKey key)
    {
        int hashCode = EqualityComparer<TKey>.Default.GetHashCode(key);

        // Convert the hash code into a valid bucket index.
        return (hashCode & 0x7FFFFFFF) % _buckets.Length;
    }

    // Returns an enumerator so the dictionary can be used with foreach.
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        // Visit every bucket.
        foreach (List<Entry> bucket in _buckets)
        {
            // Visit every entry inside the bucket.
            foreach (Entry entry in bucket)
            {
                yield return new KeyValuePair<TKey, TValue>(
                    entry.Key,
                    entry.Value);
            }
        }
    }

    // Non-generic IEnumerator implementation required by IEnumerable.
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}