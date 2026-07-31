using System;

namespace ECommerceOrderManagement.Models
{
    // Represents a customer order.
    public class Order
    {
        // Gets or sets the unique order ID.
        public int OrderId { get; set; }

        // Gets or sets the customer name.
        public string CustomerName { get; set; }

        // Gets or sets the product name.
        public string ProductName { get; set; }

        // Gets or sets the quantity ordered.
        public int Quantity { get; set; }

        // Gets or sets the price of one product.
        public decimal Price { get; set; }

        // Gets or sets the current order status.
        public string Status { get; set; }

        // Calculates the total amount of the order.
        public decimal TotalAmount => Quantity * Price;

        /// <summary>
        /// Initializes a new Order object.
        /// </summary>
   
        public Order(
            int orderId,
            string customerName,
            string productName,
            int quantity,
            decimal price,
            string status)
        {
            // Store the order ID.
            OrderId = orderId;

            // Store the customer name.
            CustomerName = customerName;

            // Store the product name.
            ProductName = productName;

            // Store the ordered quantity.
            Quantity = quantity;

            // Store the product price.
            Price = price;

            // Store the order status.
            Status = status;
        }

        /// <summary>
        /// Returns the formatted order details.
        /// </summary>

        public override string ToString()
        {
            // Return all order details in a readable format.
            return
                $"Order ID : {OrderId}\n" +
                $"Customer : {CustomerName}\n" +
                $"Product  : {ProductName}\n" +
                $"Quantity : {Quantity}\n" +
                $"Price    : ₹{Price}\n" +
                $"Status   : {Status}\n" +
                $"Total    : ₹{TotalAmount}\n";
        }
    }
}