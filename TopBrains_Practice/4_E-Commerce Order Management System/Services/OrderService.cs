using System;
using System.Collections.Generic;
using System.Linq;
using ECommerceOrderManagement.Models;

namespace ECommerceOrderManagement.Services
{
    // Performs all operations related to customer orders.
    public class OrderService
    {
        // List to store all parsed orders.
        private List<Order> orders = new List<Order>();

        /// <summary>
        /// Loads and parses pipe-separated order records.
        /// </summary>
        public void LoadOrders(List<string> records)
        {
            // Traverse each record.
            foreach (string record in records)
            {
                // Split the record using pipe delimiter.
                string[] data = record.Split('|');

                // Create an Order object and add it to the list.
                orders.Add(
                    new Order(
                        int.Parse(data[0]),          // Order ID
                        data[1].Trim(),              // Customer Name
                        data[2].Trim(),              // Product Name
                        int.Parse(data[3]),          // Quantity
                        decimal.Parse(data[4]),      // Price
                        data[5].Trim()               // Status
                    )
                );
            }
        }

        /// <summary>
        /// Displays all customer orders.
        /// </summary>
        public void DisplayOrders()
        {
            // Check whether orders are available.
            if (orders.Count == 0)
            {
                Console.WriteLine("No orders found.");
                return;
            }

            // Display every order.
            foreach (Order order in orders)
            {
                Console.WriteLine(order);
            }
        }

        /// <summary>
        /// Searches an order using Order ID.
        /// </summary>

        public void SearchOrder(int orderId)
        {
            // Find the first matching order.
            Order order = orders.FirstOrDefault(o => o.OrderId == orderId);

            // Check whether order exists.
            if (order != null)
            {
                Console.WriteLine("\nOrder Found\n");
                Console.WriteLine(order);
            }
            else
            {
                Console.WriteLine("\nOrder not found.");
            }
        }

        /// <summary>
        /// Calculates total sales amount.
        /// </summary>
        public void CalculateTotalSales()
        {
            // Variable to store total sales.
            decimal totalSales = 0;

            // Traverse every order.
            foreach (Order order in orders)
            {
                // Add order amount.
                totalSales += order.TotalAmount;
            }

            // Display total sales.
            Console.WriteLine($"\nTotal Sales : ₹{totalSales}");
        }

        /// <summary>
        /// Counts orders based on status.
        /// </summary>
        public void CountOrdersByStatus()
        {
            // Group orders according to their status.
            var groupedOrders = orders.GroupBy(o => o.Status);

            Console.WriteLine("\nOrders By Status");

            // Display count of every group.
            foreach (var group in groupedOrders)
            {
                Console.WriteLine($"{group.Key} : {group.Count()}");
            }
        }

        /// <summary>
        /// Displays orders of a particular customer.
        /// </summary>
        
        public void DisplayOrdersByCustomer(string customerName)
        {
            // Flag to check whether customer exists.
            bool found = false;

            // Traverse every order.
            foreach (Order order in orders)
            {
                // Compare customer names ignoring case.
                if (order.CustomerName.Equals(customerName,
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(order);
                    found = true;
                }
            }

            // Display message if customer not found.
            if (!found)
            {
                Console.WriteLine("Customer not found.");
            }
        }

        /// <summary>
        /// Converts customer names to uppercase.
        /// </summary>
        public void ConvertCustomerNamesToUpper()
        {
            // Traverse all orders.
            foreach (Order order in orders)
            {
                // Convert customer name to uppercase.
                order.CustomerName = order.CustomerName.ToUpper();
            }

            Console.WriteLine("Customer names converted to uppercase.");
        }

        /// <summary>
        /// Updates Pending status to Processing.
        /// </summary>
        public void UpdatePendingOrders()
        {
            // Traverse every order.
            foreach (Order order in orders)
            {
                // Check if order status is Pending.
                if (order.Status.Equals("Pending",
                    StringComparison.OrdinalIgnoreCase))
                {
                    // Replace Pending with Processing.
                    order.Status = order.Status.Replace(
                        "Pending",
                        "Processing");
                }
            }

            Console.WriteLine("Pending orders updated successfully.");
        }

        /// <summary>
        /// Returns total number of orders.
        /// </summary>
        public void TotalOrders()
        {
            // Display total number of orders.
            Console.WriteLine($"Total Orders : {orders.Count}");
        }
    }
}