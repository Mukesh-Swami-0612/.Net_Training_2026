namespace QuickBite.Models;

// Summary: Defines a common identity contract for domain entities.
public interface IEntity
{
    // Every entity must provide an integer ID.
    int Id { get; }
}