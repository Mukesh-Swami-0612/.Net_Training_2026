namespace QuickBite.Models;

// Summary: Represents a food item available in a restaurant menu.
public class MenuItem : IEntity
{
    // Unique menu item identifier.
    public int Id { get; set; }

    // Name of the food item.
    public string Name { get; set; }

    // Price of the food item.
    public decimal Price { get; set; }

    // Summary: Creates a menu item with its basic information.
    public MenuItem(int id, string name, decimal price)
    {
        // Store the menu item ID.
        Id = id;

        // Store the menu item name.
        Name = name;

        // Store the menu item price.
        Price = price;
    }

    // Summary: Returns a readable representation of the menu item.
    public override string ToString()
    {
        // Display ID, name, and formatted price.
        return $"{Id} - {Name} - ₹{Price:F2}";
    }
}