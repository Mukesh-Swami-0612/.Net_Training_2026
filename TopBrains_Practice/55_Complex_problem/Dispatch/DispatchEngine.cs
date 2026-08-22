using QuickBite.Models;
using QuickBite.Repositories;

namespace QuickBite.Dispatch;

// Summary: Coordinates dispatching, delivery agents, undo operations, and reports.
public class DispatchEngine
{
    // Repository containing all restaurants.
    private readonly Repository<Restaurant> _restaurants;

    // Repository containing all customers.
    private readonly Repository<Customer> _customers;

    // Repository containing all orders.
    private readonly Repository<Order> _orders;

    // Queue responsible for order priority.
    private readonly DispatchQueue _dispatchQueue;

    // Linked list representing the rotating delivery agent roster.
    private readonly LinkedList<DeliveryAgent> _agents;

    // Stack containing recent dispatch operations for undo.
    private readonly Stack<DispatchRecord> _dispatchHistory;

    // Summary: Creates the dispatch engine with the required repositories.
    public DispatchEngine(
        Repository<Restaurant> restaurants,
        Repository<Customer> customers,
        Repository<Order> orders)
    {
        // Store the restaurant repository.
        _restaurants = restaurants;

        // Store the customer repository.
        _customers = customers;

        // Store the order repository.
        _orders = orders;

        // Initialize the dispatch queue.
        _dispatchQueue = new DispatchQueue();

        // Initialize the delivery agent roster.
        _agents = new LinkedList<DeliveryAgent>();

        // Initialize the dispatch history stack.
        _dispatchHistory = new Stack<DispatchRecord>();
    }

    // Summary: Adds a delivery agent to the rotating roster.
    public void AddDeliveryAgent(DeliveryAgent agent)
    {
        // Add the new agent to the end of the roster.
        _agents.AddLast(agent);
    }

    // Summary: Stores an order and places it into the dispatch queue.
    public void QueueOrder(Order order)
    {
        // Store the order in the order repository.
        _orders.Add(order);

        // Place the order into the appropriate priority queue.
        _dispatchQueue.Enqueue(order);
    }

    // Summary: Gets the next available agent and rotates that agent to the back.
    public DeliveryAgent GetNextAvailableAgent()
    {
        // Ensure at least one agent exists.
        if (_agents.Count == 0)
        {
            throw new InvalidOperationException(
                "No delivery agents are registered.");
        }

        // Start searching from the first agent.
        LinkedListNode<DeliveryAgent>? current = _agents.First;

        // Search through the roster.
        while (current != null)
        {
            // Get the current agent.
            DeliveryAgent agent = current.Value;

            // Check whether the agent is available.
            if (agent.IsAvailable)
            {
                // Remove the agent from its current position.
                _agents.Remove(current);

                // Move the agent to the back of the roster.
                _agents.AddLast(agent);

                // Mark the agent as busy.
                agent.IsAvailable = false;

                // Return the selected agent.
                return agent;
            }

            // Move to the next agent.
            current = current.Next;
        }

        // No available agent was found.
        throw new InvalidOperationException(
            "No delivery agents are currently available.");
    }

    // Summary: Dispatches the highest-priority pending order to an agent.
    public DispatchRecord DispatchNextOrder()
    {
        // Check whether an order is waiting.
        if (!_dispatchQueue.HasOrders)
        {
            throw new InvalidOperationException(
                "No orders are waiting for dispatch.");
        }

        // Select the next available delivery agent.
        DeliveryAgent agent = GetNextAvailableAgent();

        // Select the next order according to priority.
        Order order = _dispatchQueue.DispatchNext();

        // Change the order status to Dispatched.
        order.Status = OrderStatus.Dispatched;

        // Create a record for the dispatch.
        DispatchRecord record = new DispatchRecord(
            order,
            agent,
            DateTime.Now);

        // Store the dispatch in the undo stack.
        _dispatchHistory.Push(record);

        // Return the dispatch information.
        return record;
    }

    // Summary: Marks a dispatched order as delivered and frees its agent.
    public void CompleteDelivery(DispatchRecord record)
    {
        // Change the order status to Delivered.
        record.Order.Status = OrderStatus.Delivered;

        // Make the delivery agent available again.
        record.Agent.IsAvailable = true;
    }

    // Summary: Reverts the most recent dispatch and requeues the order.
    public DispatchRecord UndoLastDispatch()
    {
        // Check whether there is a dispatch to undo.
        if (_dispatchHistory.Count == 0)
        {
            throw new InvalidOperationException(
                "There is no dispatch to undo.");
        }

        // Remove the latest dispatch from the stack.
        DispatchRecord record = _dispatchHistory.Pop();

        // Revert the order status.
        record.Order.Status = OrderStatus.Queued;

        // Make the delivery agent available again.
        record.Agent.IsAvailable = true;

        // Put the order back into its appropriate priority queue.
        _dispatchQueue.Enqueue(record.Order);

        // Remove the agent from its current position.
        _agents.Remove(record.Agent);

        // Place the agent at the front of the roster.
        _agents.AddFirst(record.Agent);

        // Return information about the undone dispatch.
        return record;
    }

    // Summary: Finds unique customer IDs for orders placed today.
    public HashSet<int> TodaysUniqueCustomerIds()
    {
        // Get today's date.
        DateTime today = DateTime.Today;

        // HashSet prevents duplicate customer IDs.
        HashSet<int> customerIds = new();

        // Check every stored order.
        foreach (Order order in _orders)
        {
            // Only process orders placed today.
            if (order.PlacedAt.Date == today)
            {
                // Add the customer ID to the set.
                customerIds.Add(order.Customer.Id);
            }
        }

        // Return the unique customer IDs.
        return customerIds;
    }

    // Summary: Finds restaurants having fewer menu items than the threshold.
    public Dictionary<int, int> LowAvailabilityRestaurants(
        int minMenuItems)
    {
        // Store restaurant ID and menu count.
        Dictionary<int, int> result = new();

        // Check every restaurant.
        foreach (Restaurant restaurant in _restaurants)
        {
            // Check whether the restaurant is below the threshold.
            if (restaurant.Menu.Count < minMenuItems)
            {
                // Store restaurant ID and current menu item count.
                result[restaurant.Id] = restaurant.Menu.Count;
            }
        }

        // Return restaurants with low availability.
        return result;
    }

    // Summary: Calculates and returns the most frequently ordered menu items.
    public List<(string ItemName, int TotalOrdered)> TopOrderedItems(
        int topN)
    {
        // Stores item name and total quantity ordered.
        Dictionary<string, int> totals =
            new(StringComparer.OrdinalIgnoreCase);

        // Process every order.
        foreach (Order order in _orders)
        {
            // Process every item inside the order.
            foreach (OrderItem item in order.Items)
            {
                // Check whether the item already has a count.
                if (totals.ContainsKey(item.MenuItem.Name))
                {
                    // Increase the existing quantity.
                    totals[item.MenuItem.Name] += item.Quantity;
                }
                else
                {
                    // Create a new quantity entry.
                    totals[item.MenuItem.Name] = item.Quantity;
                }
            }
        }

        // Sort by quantity, limit the result, and return a list.
        return totals
            .OrderByDescending(item => item.Value)
            .ThenBy(item => item.Key)
            .Take(topN)
            .Select(item => (item.Key, item.Value))
            .ToList();
    }

    // Summary: Checks whether a customer ordered from both specified restaurants.
    public bool CustomerOrderedFromBothRestaurants(
        int customerId,
        int restaurantIdA,
        int restaurantIdB)
    {
        // Stores restaurant IDs from the customer's order history.
        HashSet<int> restaurantHistory = new();

        // Check every stored order.
        foreach (Order order in _orders)
        {
            // Process only orders belonging to the requested customer.
            if (order.Customer.Id == customerId)
            {
                // Add the restaurant ID to the customer's history.
                restaurantHistory.Add(order.Restaurant.Id);
            }
        }

        // Both restaurant IDs must exist in the set.
        return restaurantHistory.Contains(restaurantIdA) &&
               restaurantHistory.Contains(restaurantIdB);
    }

    // Summary: Returns pending orders using the custom priority comparer.
    public List<Order> GetPriorityViewOfPendingOrders()
    {
        // Get pending orders and sort them using OrderPriorityComparer.
        return _dispatchQueue
            .GetPendingOrders()
            .OrderBy(
                order => order,
                new OrderPriorityComparer())
            .ToList();
    }

    // Summary: Returns the number of orders currently waiting for dispatch.
    public int PendingOrderCount()
    {
        // Return the total number of pending orders.
        return _dispatchQueue.Count;
    }
}