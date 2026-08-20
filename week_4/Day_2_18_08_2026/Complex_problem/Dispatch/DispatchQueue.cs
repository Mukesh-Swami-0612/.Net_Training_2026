using QuickBite.Models;

namespace QuickBite.Dispatch;

// Summary: Manages pending orders using priority queues while preserving FIFO.
public class DispatchQueue
{
    // Stores Express orders with the highest priority.
    private readonly Queue<Order> _expressOrders = new();

    // Stores VIP orders with the second-highest priority.
    private readonly Queue<Order> _vipOrders = new();

    // Stores normal orders with the lowest priority.
    private readonly Queue<Order> _normalOrders = new();

    // Summary: Places an order into the correct priority queue.
    public void Enqueue(Order order)
    {
        // Express orders always receive the highest priority.
        if (order.IsExpress)
        {
            _expressOrders.Enqueue(order);
        }
        // Non-express VIP orders receive the second priority.
        else if (order.Customer.IsVip)
        {
            _vipOrders.Enqueue(order);
        }
        // All remaining orders are normal priority.
        else
        {
            _normalOrders.Enqueue(order);
        }

        // Change the order status after placing it in the queue.
        order.Status = OrderStatus.Queued;
    }

    // Summary: Removes and returns the next order according to priority.
    public Order DispatchNext()
    {
        // Dispatch Express orders first.
        if (_expressOrders.Count > 0)
        {
            return _expressOrders.Dequeue();
        }

        // Dispatch VIP orders next.
        if (_vipOrders.Count > 0)
        {
            return _vipOrders.Dequeue();
        }

        // Dispatch normal orders last.
        if (_normalOrders.Count > 0)
        {
            return _normalOrders.Dequeue();
        }

        // No order is available.
        throw new InvalidOperationException(
            "There are no orders waiting for dispatch.");
    }

    // Summary: Indicates whether the queue contains any pending orders.
    public bool HasOrders =>
        _expressOrders.Count > 0 ||
        _vipOrders.Count > 0 ||
        _normalOrders.Count > 0;

    // Summary: Returns the total number of pending orders.
    public int Count =>
        _expressOrders.Count +
        _vipOrders.Count +
        _normalOrders.Count;

    // Summary: Returns pending orders in dispatch priority order.
    public IEnumerable<Order> GetPendingOrders()
    {
        // Return all Express orders first.
        foreach (Order order in _expressOrders)
        {
            yield return order;
        }

        // Return all VIP orders second.
        foreach (Order order in _vipOrders)
        {
            yield return order;
        }

        // Return all normal orders last.
        foreach (Order order in _normalOrders)
        {
            yield return order;
        }
    }
}