namespace QuickBite.Models;

// Summary: Represents a restaurant and its collection of menu items.
public class Restaurant : IEntity
{
    // Unique restaurant identifier.
    public int Id { get; set; }

    // Restaurant name.
    public string Name { get; set; }

    // Indicates whether the restaurant is accepting orders.
    public bool IsOpen { get; set; }

    // Stores menu items using the menu item ID as the key.
    public Dictionary<int, MenuItem> Menu { get; }

    // Summary: Creates a restaurant and initializes its menu.
    public Restaurant(int id, string name, bool isOpen)
    {
        // Store the restaurant ID.
        Id = id;

        // Store the restaurant name.
        Name = name;

        // Store the restaurant open/closed status.
        IsOpen = isOpen;

        // Initialize the menu dictionary.
        Menu = new Dictionary<int, MenuItem>();
    }

    // Summary: Adds a menu item to the restaurant menu.
    public void AddMenuItem(MenuItem item)
    {
        // Use the menu item ID as the dictionary key.
        Menu[item.Id] = item;
    }

    // Summary: Returns a readable representation of the restaurant.
    public override string ToString()
    {
        // Display restaurant information and menu count.
        return $"{Id} - {Name} - {(IsOpen ? "Open" : "Closed")} - {Menu.Count} menu items";
    }
}