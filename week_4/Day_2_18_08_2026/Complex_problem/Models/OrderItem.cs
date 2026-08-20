namespace QuickBite.Models;

// Summary: Represents one menu item and its quantity inside an order.
public class OrderItem
{
    // Menu item being ordered.
    public MenuItem MenuItem { get; set; }

    // Number of units ordered.
    public int Quantity { get; set; }

    // Summary: Creates an order item with a menu item and quantity.
    public OrderItem(MenuItem menuItem, int quantity)
    {
        // Store the menu item.
        MenuItem = menuItem;

        // Store the requested quantity.
        Quantity = quantity;
    }

    // Summary: Calculates the total price for this order item.
    public decimal GetLineTotal()
    {
        // Multiply the item price by its quantity.
        return MenuItem.Price * Quantity;
    }
}