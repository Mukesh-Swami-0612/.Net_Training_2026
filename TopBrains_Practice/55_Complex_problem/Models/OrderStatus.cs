namespace QuickBite.Models;

// Summary: Defines the possible states of a QuickBite order.
public enum OrderStatus
{
    // Order has been created.
    Placed,

    // Order is waiting in the dispatch queue.
    Queued,

    // Order has been assigned to a delivery agent.
    Dispatched,

    // Order has been successfully delivered.
    Delivered,

    // Order has been cancelled.
    Cancelled
}