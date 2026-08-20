using QuickBite.Models;

namespace QuickBite.Repositories;

// Summary: Provides a reusable generic repository for IEntity objects.
public class Repository<T> : IEnumerable<T>
    where T : class, IEntity
{
    // Stores entities using their integer ID as the dictionary key.
    private readonly Dictionary<int, T> _items = new();

    // Summary: Adds a new entity to the repository.
    public void Add(T entity)
    {
        // Prevent duplicate entity IDs.
        if (_items.ContainsKey(entity.Id))
        {
            throw new InvalidOperationException(
                $"Entity with ID {entity.Id} already exists.");
        }

        // Add the entity using its ID as the key.
        _items.Add(entity.Id, entity);
    }

    // Summary: Updates an existing entity in the repository.
    public void Update(T entity)
    {
        // Check that the entity already exists.
        if (!_items.ContainsKey(entity.Id))
        {
            throw new KeyNotFoundException(
                $"Entity with ID {entity.Id} was not found.");
        }

        // Replace the existing entity.
        _items[entity.Id] = entity;
    }

    // Summary: Removes an entity using its ID.
    public bool Remove(int id)
    {
        // Remove the entity and return whether removal succeeded.
        return _items.Remove(id);
    }

    // Summary: Finds an entity using its ID.
    public T? GetById(int id)
    {
        // Try to find the entity without throwing an exception.
        _items.TryGetValue(id, out T? entity);

        // Return the entity if found, otherwise null.
        return entity;
    }

    // Summary: Returns all entities stored in the repository.
    public IEnumerable<T> GetAll()
    {
        // Return the dictionary values.
        return _items.Values;
    }

    // Summary: Allows the repository to be used directly in foreach.
    public IEnumerator<T> GetEnumerator()
    {
        // Return an enumerator over all stored entities.
        return _items.Values.GetEnumerator();
    }

    // Summary: Provides the non-generic IEnumerable implementation.
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        // Reuse the generic enumerator.
        return GetEnumerator();
    }
}