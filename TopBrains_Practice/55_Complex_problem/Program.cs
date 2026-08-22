using QuickBite.Dispatch;
using QuickBite.Models;
using QuickBite.Repositories;

// ===================================================
// QUICKBITE REAL-TIME FOOD DELIVERY & DISPATCH ENGINE
// ===================================================

// Create a generic repository for restaurants.
Repository<Restaurant> restaurantRepository = new();

// Create a generic repository for customers.
Repository<Customer> customerRepository = new();

// Create a generic repository for orders.
Repository<Order> orderRepository = new();

// ==================
// CREATE RESTAURANTS
// ==================

// Create the first restaurant.
Restaurant spicyBites =
    new Restaurant(1, "Spicy Bites", true);

// Create the second restaurant.
Restaurant pizzaCorner =
    new Restaurant(2, "Pizza Corner", true);

// Create the third restaurant.
Restaurant healthyKitchen =
    new Restaurant(3, "Healthy Kitchen", true);

// =================
// CREATE MENU ITEMS
// =================

// Create a burger menu item.
MenuItem burger =
    new MenuItem(101, "Classic Burger", 180);

// Create a biryani menu item.
MenuItem biryani =
    new MenuItem(102, "Chicken Biryani", 250);

// Create a pizza menu item.
MenuItem pizza =
    new MenuItem(103, "Farmhouse Pizza", 320);

// Create a pasta menu item.
MenuItem pasta =
    new MenuItem(104, "White Sauce Pasta", 220);

// Create a salad menu item.
MenuItem salad =
    new MenuItem(105, "Healthy Salad", 150);

// Create a soft drink menu item.
MenuItem coke =
    new MenuItem(106, "Coke", 60);

// =============================
// ADD MENU ITEMS TO RESTAURANTS
// =============================

// Add burger to Spicy Bites.
spicyBites.AddMenuItem(burger);

// Add biryani to Spicy Bites.
spicyBites.AddMenuItem(biryani);

// Add coke to Spicy Bites.
spicyBites.AddMenuItem(coke);

// Add pizza to Pizza Corner.
pizzaCorner.AddMenuItem(pizza);

// Add pasta to Pizza Corner.
pizzaCorner.AddMenuItem(pasta);

// Add coke to Pizza Corner.
pizzaCorner.AddMenuItem(coke);

// Add salad to Healthy Kitchen.
healthyKitchen.AddMenuItem(salad);

// =============================
// ADD RESTAURANTS TO REPOSITORY
// =============================

// Store Spicy Bites.
restaurantRepository.Add(spicyBites);

// Store Pizza Corner.
restaurantRepository.Add(pizzaCorner);

// Store Healthy Kitchen.
restaurantRepository.Add(healthyKitchen);

// ================
// CREATE CUSTOMERS
// ================

// Create a VIP customer.
Customer mukesh =
    new Customer(1, "Mukesh Kumar", true);

// Create a normal customer.
Customer rahul =
    new Customer(2, "Rahul Sharma", false);

// Create another VIP customer.
Customer priya =
    new Customer(3, "Priya Singh", true);

// Create another normal customer.
Customer ankit =
    new Customer(4, "Ankit Verma", false);

// ============================
// ADD CUSTOMERS TO REPOSITORY
// ============================

// Store Mukesh.
customerRepository.Add(mukesh);

// Store Rahul.
customerRepository.Add(rahul);

// Store Priya.
customerRepository.Add(priya);

// Store Ankit.
customerRepository.Add(ankit);

// ======================
// CREATE DISPATCH ENGINE
// ======================

// Create the main dispatch engine.
DispatchEngine engine =
    new DispatchEngine(
        restaurantRepository,
        customerRepository,
        orderRepository);

// =======================
// CREATE DELIVERY AGENTS
// =======================

// Create first delivery agent.
DeliveryAgent agent1 =
    new DeliveryAgent(1, "Amit");

// Create second delivery agent.
DeliveryAgent agent2 =
    new DeliveryAgent(2, "Suresh");

// Create third delivery agent.
DeliveryAgent agent3 =
    new DeliveryAgent(3, "Ravi");

// Add agents to the rotating roster.
engine.AddDeliveryAgent(agent1);

// Add second agent to the roster.
engine.AddDeliveryAgent(agent2);

// Add third agent to the roster.
engine.AddDeliveryAgent(agent3);

// =============
// CREATE ORDERS
// =============

// Create a normal order from Rahul.
Order order1 =
    new Order(
        1001,
        rahul,
        spicyBites,
        DateTime.Now.AddMinutes(-25),
        false);

// Add two burgers.
order1.AddItem(burger, 2);

// Add two cokes.
order1.AddItem(coke, 2);

// Create a VIP order from Mukesh.
Order order2 =
    new Order(
        1002,
        mukesh,
        pizzaCorner,
        DateTime.Now.AddMinutes(-20),
        false);

// Add one pizza.
order2.AddItem(pizza, 1);

// Add one coke.
order2.AddItem(coke, 1);

// Create an Express order from Ankit.
Order order3 =
    new Order(
        1003,
        ankit,
        healthyKitchen,
        DateTime.Now.AddMinutes(-15),
        true);

// Add two salads.
order3.AddItem(salad, 2);

// Create a VIP order from Priya.
Order order4 =
    new Order(
        1004,
        priya,
        spicyBites,
        DateTime.Now.AddMinutes(-10),
        false);

// Add one biryani.
order4.AddItem(biryani, 1);

// Create another normal order from Rahul.
Order order5 =
    new Order(
        1005,
        rahul,
        pizzaCorner,
        DateTime.Now.AddMinutes(-5),
        false);

// Add two pasta items.
order5.AddItem(pasta, 2);

// ============
// QUEUE ORDERS
// ============

// Add the first order to the system.
engine.QueueOrder(order1);

// Add the second order to the system.
engine.QueueOrder(order2);

// Add the third order to the system.
engine.QueueOrder(order3);

// Add the fourth order to the system.
engine.QueueOrder(order4);

// Add the fifth order to the system.
engine.QueueOrder(order5);

// ===================
// DISPLAY ALL ORDERS
// ===================

Console.WriteLine("===========");
Console.WriteLine("ALL ORDERS");
Console.WriteLine("===========");

// Iterate through Repository<Order>.
foreach (Order order in orderRepository)
{
    // Display each order.
    Console.WriteLine(order);
}

// ========================================
// DISPLAY PRIORITY VIEW
// ========================================

Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine("DISPATCH PRIORITY VIEW");
Console.WriteLine("======================");

// Get orders according to custom priority.
List<Order> priorityOrders =
    engine.GetPriorityViewOfPendingOrders();

// Display each pending order.
foreach (Order order in priorityOrders)
{
    // Print the priority-sorted order.
    Console.WriteLine(order);
}

// ==============
// FIRST DISPATCH
// ==============

Console.WriteLine();
Console.WriteLine("================");
Console.WriteLine("FIRST DISPATCH");
Console.WriteLine("================");

// Dispatch the next order.
DispatchRecord dispatch1 =
    engine.DispatchNextOrder();

// Display the assigned order and agent.
Console.WriteLine(
    $"Order {dispatch1.Order.Id} assigned to " +
    $"{dispatch1.Agent.Name}");

// Display the updated order status.
Console.WriteLine(
    $"Order status: {dispatch1.Order.Status}");

// ===============
// SECOND DISPATCH
// ===============

Console.WriteLine();
Console.WriteLine("================");
Console.WriteLine("SECOND DISPATCH");
Console.WriteLine("================");

// Dispatch another order.
DispatchRecord dispatch2 =
    engine.DispatchNextOrder();

// Display the assigned order and agent.
Console.WriteLine(
    $"Order {dispatch2.Order.Id} assigned to " +
    $"{dispatch2.Agent.Name}");

// Display the updated status.
Console.WriteLine(
    $"Order status: {dispatch2.Order.Status}");

// ==================
// UNDO LAST DISPATCH
// ==================

Console.WriteLine();
Console.WriteLine("===================");
Console.WriteLine("UNDO LAST DISPATCH");
Console.WriteLine("===================");

// Undo the most recent dispatch.
DispatchRecord undone =
    engine.UndoLastDispatch();

// Display the undone order.
Console.WriteLine(
    $"Dispatch for Order {undone.Order.Id} was undone.");

// Display the reverted status.
Console.WriteLine(
    $"Order status after undo: {undone.Order.Status}");

// Display the agent information.
Console.WriteLine(
    $"Agent {undone.Agent.Name} returned to roster.");

// =======================
// TODAY'S UNIQUE CUSTOMERS
// =======================

Console.WriteLine();
Console.WriteLine("========================");
Console.WriteLine("TODAY'S UNIQUE CUSTOMERS");
Console.WriteLine("========================");

// Get unique customer IDs for today's orders.
HashSet<int> uniqueCustomers =
    engine.TodaysUniqueCustomerIds();

// Display each unique customer.
foreach (int customerId in uniqueCustomers)
{
    // Find the customer from the repository.
    Customer? customer =
        customerRepository.GetById(customerId);

    // Check whether the customer exists.
    if (customer != null)
    {
        // Display the customer.
        Console.WriteLine(
            $"{customer.Id} - {customer.Name}");
    }
}

// ===========================
// LOW AVAILABILITY RESTAURANTS
// ===========================

Console.WriteLine();
Console.WriteLine("============================");
Console.WriteLine("LOW AVAILABILITY RESTAURANTS");
Console.WriteLine("============================");

// Find restaurants with fewer than three menu items.
Dictionary<int, int> lowAvailability =
    engine.LowAvailabilityRestaurants(3);

// Display each restaurant and its menu count.
foreach (KeyValuePair<int, int> item in lowAvailability)
{
    // Find the restaurant by ID.
    Restaurant? restaurant =
        restaurantRepository.GetById(item.Key);

    // Check whether the restaurant exists.
    if (restaurant != null)
    {
        // Display restaurant name and menu count.
        Console.WriteLine(
            $"{restaurant.Name} -> {item.Value} menu items");
    }
}

// =================
// TOP ORDERED ITEMS
// =================

Console.WriteLine();
Console.WriteLine("=================");
Console.WriteLine("TOP ORDERED ITEMS");
Console.WriteLine("=================");

// Get the top five ordered items.
List<(string ItemName, int TotalOrdered)> topItems =
    engine.TopOrderedItems(5);

// Display each item and quantity.
foreach (var item in topItems)
{
    // Print item name and total quantity.
    Console.WriteLine(
        $"{item.ItemName} -> {item.TotalOrdered} ordered");
}

// ===========================
// CUSTOMER RESTAURANT HISTORY
// ===========================
Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine("CUSTOMER RESTAURANT HISTORY CHECK");
Console.WriteLine("=================================");

// Check whether Rahul ordered from both restaurants.
bool orderedFromBoth =
    engine.CustomerOrderedFromBothRestaurants(
        rahul.Id,
        spicyBites.Id,
        pizzaCorner.Id);

// Display the question.
Console.WriteLine(
    $"Did {rahul.Name} order from both " +
    $"{spicyBites.Name} and {pizzaCorner.Name}?");

// Display the result.
Console.WriteLine(
    orderedFromBoth ? "Yes" : "No");

// ================
// COMPLETE DELIVERY
// ================

Console.WriteLine();
Console.WriteLine("=================");
Console.WriteLine("COMPLETE DELIVERY");
Console.WriteLine("=================");

// Mark the first dispatched order as delivered.
engine.CompleteDelivery(dispatch1);

// Display delivery information.
Console.WriteLine(
    $"Order {dispatch1.Order.Id} delivered by " +
    $"{dispatch1.Agent.Name}");

// Display the final order status.
Console.WriteLine(
    $"Final order status: {dispatch1.Order.Status}");

// ===================
// FINAL SYSTEM STATUS
// ===================

Console.WriteLine();
Console.WriteLine("===================");
Console.WriteLine("FINAL SYSTEM STATUS");
Console.WriteLine("===================");

// Display the number of remaining pending orders.
Console.WriteLine(
    $"Pending orders: {engine.PendingOrderCount()}");

// Display completion message.
Console.WriteLine("QuickBite simulation completed.");