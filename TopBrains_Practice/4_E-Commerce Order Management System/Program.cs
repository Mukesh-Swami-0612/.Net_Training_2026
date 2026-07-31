using System;
using System.Collections.Generic;
using ECommerceOrderManagement.Services;

namespace ECommerceOrderManagement
{
    class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// </summary>
        static void Main(string[] args)
        {
            // Create an object of OrderService.
            OrderService orderService = new OrderService();

            // Create sample pipe-separated order records.
            List<string> orderRecords = new List<string>()
            {
                "101|Rahul|Laptop|2|55000|Pending",
                "102|Priya|Mouse|3|750|Delivered",
                "103|Amit|Keyboard|1|1800|Pending",
                "104|Neha|Monitor|2|12000|Processing",
                "105|Rahul|Headphones|1|2500|Delivered"
            };

            Console.WriteLine("======================================");
            Console.WriteLine(" E-Commerce Order Management System");
            Console.WriteLine("======================================");

            // Load all records into the system.
            orderService.LoadOrders(orderRecords);

            Console.WriteLine("\n1. Display All Orders");
            Console.WriteLine("----------------------------");

            // Display all orders.
            orderService.DisplayOrders();

            Console.WriteLine("\n2. Search Order By ID");
            Console.WriteLine("----------------------------");

            // Search order using Order ID.
            orderService.SearchOrder(103);

            Console.WriteLine("\n3. Calculate Total Sales");
            Console.WriteLine("----------------------------");

            // Calculate total sales amount.
            orderService.CalculateTotalSales();

            Console.WriteLine("\n4. Count Orders By Status");
            Console.WriteLine("----------------------------");

            // Count orders according to their status.
            orderService.CountOrdersByStatus();

            Console.WriteLine("\n5. Display Orders of Rahul");
            Console.WriteLine("----------------------------");

            // Display all orders of Rahul.
            orderService.DisplayOrdersByCustomer("Rahul");

            Console.WriteLine("\n6. Convert Customer Names To Uppercase");
            Console.WriteLine("----------------------------");

            // Convert all customer names to uppercase.
            orderService.ConvertCustomerNamesToUpper();

            // Display updated orders.
            orderService.DisplayOrders();

            Console.WriteLine("\n7. Update Pending Orders");
            Console.WriteLine("----------------------------");

            // Replace Pending status with Processing.
            orderService.UpdatePendingOrders();

            // Display updated records.
            orderService.DisplayOrders();

            Console.WriteLine("\n8. Total Orders");
            Console.WriteLine("----------------------------");

            // Display total number of orders.
            orderService.TotalOrders();

            Console.WriteLine("\nProgram completed successfully.");

            // Pause the console window.
            Console.ReadKey();
        }
    }
}