namespace QuickBite.Models;

// Summary: Represents a delivery agent who can receive and complete orders.
public class DeliveryAgent
{
    // Unique delivery agent identifier.
    public int Id { get; set; }

    // Delivery agent name.
    public string Name { get; set; }

    // Indicates whether the agent is available.
    public bool IsAvailable { get; set; }

    // Summary: Creates a delivery agent and marks the agent as available.
    public DeliveryAgent(int id, string name)
    {
        // Store the agent ID.
        Id = id;

        // Store the agent name.
        Name = name;

        // New agents are available by default.
        IsAvailable = true;
    }

    // Summary: Returns a readable representation of the delivery agent.
    public override string ToString()
    {
        // Display agent information and availability.
        return $"{Id} - {Name} - {(IsAvailable ? "Available" : "Busy")}";
    }
}