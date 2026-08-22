using System;
using System.Collections.Generic;

namespace Lab6LambdaExpressions
{
    // Order represents a customer's complete order.
    public class Order
    {
        // Unique order number.
        public string OrderId { get; set; }

        // Customer name.
        public string CustomerName { get; set; }

        // List of products/items in the order.
        public List<OrderItem> Items { get; set; }

        // Constructor used to create an Order.
        public Order(string orderId, string customerName)
        {
            OrderId = orderId;
            CustomerName = customerName;
            Items = new List<OrderItem>();
        }

        // Adds an item to the order.
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        // Calculates the complete order total.
        public double GetTotal()
        {
            double total = 0;

            foreach (OrderItem item in Items)
            {
                total += item.GetTotal();
            }

            return total;
        }
    }
}