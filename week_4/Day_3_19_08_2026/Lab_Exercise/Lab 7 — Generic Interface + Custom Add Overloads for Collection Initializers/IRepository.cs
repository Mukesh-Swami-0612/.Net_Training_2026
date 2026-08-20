using System.Collections.Generic;

namespace Lab7;

// Defines common repository operations for reference-type entities.
public interface IRepository<T> where T : class
{
    // Adds an item to the repository.
    void Add(T item);

    // Gets an item by its ID.
    T? GetById(int id);

    // Returns all items in the repository.
    IEnumerable<T> GetAll();
}