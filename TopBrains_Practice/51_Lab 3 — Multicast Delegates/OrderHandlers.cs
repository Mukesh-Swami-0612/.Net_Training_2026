namespace MulticastDelegateLab;

public class OrderHandlers
{
    // Logs the order information to the console.
    public void LogToConsole(string orderId)
    {
        Console.WriteLine($"[Console Log] Order received: {orderId}");
    }

    // Simulates sending an email for the order.
    public void SendEmailSimulation(string orderId)
    {
        Console.WriteLine($"[Email Simulation] Email sent for order: {orderId}");
    }

    // Simulates updating inventory for the order.
    public void UpdateInventorySimulation(string orderId)
    {
        Console.WriteLine($"[Inventory Simulation] Inventory updated for order: {orderId}");
    }
}