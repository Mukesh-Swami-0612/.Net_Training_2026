namespace QuickBite.Models;

// Summary: Stores information about a dispatch operation for undo support.
public class DispatchRecord
{
    // Order that was dispatched.
    public Order Order { get; }

    // Delivery agent assigned to the order.
    public DeliveryAgent Agent { get; }

    // Date and time when the dispatch occurred.
    public DateTime DispatchedAt { get; }

    // Summary: Creates a record containing dispatch information.
    public DispatchRecord(
        Order order,
        DeliveryAgent agent,
        DateTime dispatchedAt)
    {
        // Store the dispatched order.
        Order = order;

        // Store the assigned delivery agent.
        Agent = agent;

        // Store the dispatch timestamp.
        DispatchedAt = dispatchedAt;
    }
}