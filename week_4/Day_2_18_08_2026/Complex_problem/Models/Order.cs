namespace QuickBite.Models;

// Summary: Represents a complete customer order.
public class Order : IEntity
{
    // Unique order identifier.
    public int Id { get; set; }

    // Customer who placed the order.
    public Customer Customer { get; set; }

    // Restaurant receiving the order.
    public Restaurant Restaurant { get; set; }

    // Collection of food items in the order.
    public List<OrderItem> Items { get; }

    // Date and time when the order was placed.
    public DateTime PlacedAt { get; set; }

    // Indicates whether the order has express priority.
    public bool IsExpress { get; set; }

    // Current status of the order.
    public OrderStatus Status { get; set; }

    // Summary: Creates an order with customer, restaurant, time, and priority details.
    public Order(
        int id,
        Customer customer,
        Restaurant restaurant,
        DateTime placedAt,
        bool isExpress)
    {
        // Store the order ID.
        Id = id;

        // Store the customer.
        Customer = customer;

        // Store the restaurant.
        Restaurant = restaurant;

        // Store the order placement time.
        PlacedAt = placedAt;

        // Store the express flag.
        IsExpress = isExpress;

        // New orders start in the Placed state.
        Status = OrderStatus.Placed;

        // Initialize the order item collection.
        Items = new List<OrderItem>();
    }

    // Summary: Adds a menu item and quantity to the order.
    public void AddItem(MenuItem menuItem, int quantity)
    {
        // Validate that the requested quantity is positive.
        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity must be greater than zero.");
        }

        // Add the item to the order.
        Items.Add(new OrderItem(menuItem, quantity));
    }

    // Summary: Calculates the complete order value.
    public decimal GetTotal()
    {
        // Add the line total of every item in the order.
        return Items.Sum(item => item.GetLineTotal());
    }

    // Summary: Returns a readable representation of the order.
    public override string ToString()
    {
        // Determine the order's display priority.
        string priority = IsExpress
            ? "Express"
            : Customer.IsVip
                ? "VIP"
                : "Normal";

        // Display the important order information.
        return $"Order #{Id} | {Customer.Name} | {Restaurant.Name} | " +
               $"{priority} | ₹{GetTotal():F2} | {Status}";
    }
}