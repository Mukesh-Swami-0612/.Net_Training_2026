using System.Collections.Generic;

public class Order
{
    public string OrderId { get; }

    public Address? ShipTo { get; set; }

    public List<string> Items { get; set; } = new();

    public decimal Total { get; set; }

    public Order(string orderId)
    {
        OrderId = orderId;
    }
}