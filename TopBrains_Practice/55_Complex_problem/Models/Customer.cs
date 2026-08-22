namespace QuickBite.Models;

// Summary: Represents a customer who places food delivery orders.
public class Customer : IEntity
{
    // Unique customer identifier.
    public int Id { get; set; }

    // Customer name.
    public string Name { get; set; }

    // Indicates whether the customer is a VIP customer.
    public bool IsVip { get; set; }

    // Summary: Creates a customer with identity and VIP information.
    public Customer(int id, string name, bool isVip)
    {
        // Store the customer ID.
        Id = id;

        // Store the customer name.
        Name = name;

        // Store the VIP status.
        IsVip = isVip;
    }

    // Summary: Returns a readable representation of the customer.
    public override string ToString()
    {
        // Display customer information and customer type.
        return $"{Id} - {Name} - {(IsVip ? "VIP" : "Regular")}";
    }
}