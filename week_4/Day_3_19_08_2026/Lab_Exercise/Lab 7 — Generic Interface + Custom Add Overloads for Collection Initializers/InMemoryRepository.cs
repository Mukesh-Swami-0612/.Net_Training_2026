using System;
using System.Collections.Generic;

namespace Lab7;

// Provides an in-memory generic repository using a dictionary for storage.
public class InMemoryRepository<T> : IRepository<T>
    where T : class, IEntity
{
    // Stores entities using their ID as the dictionary key.
    private readonly Dictionary<int, T> _items = new();

    // Adds an entity to the repository.
    public void Add(T item)
    {
        _items[item.Id] = item;
    }

    // Gets an entity by its ID.
    public T? GetById(int id)
    {
        _items.TryGetValue(id, out T? item);
        return item;
    }

    // Returns all entities stored in the repository.
    public IEnumerable<T> GetAll()
    {
        return _items.Values;
    }
}