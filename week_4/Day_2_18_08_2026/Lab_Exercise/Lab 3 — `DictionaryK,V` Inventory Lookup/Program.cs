using System;

namespace InventoryLookup
{
    // Summary:
    // Program is the entry point of the application.
    // It demonstrates all inventory operations.
    class Program
    {
        // Summary:
        // Main creates the inventory system and demonstrates
        // restocking, selling, exception handling, and low-stock reporting.
        static void Main(string[] args)
        {
            // Create an InventoryManager object.
            InventoryManager inventory = new InventoryManager();

            // Load 8 sample SKU records into the dictionary.
            inventory.LoadSampleData();

            Console.WriteLine("===== INITIAL INVENTORY =====");

            // Display all products and their quantities.
            inventory.DisplayInventory();

            // Successful Restock

            Console.WriteLine("\n===== SUCCESSFUL RESTOCK =====");

            // Add 10 units to SKU001.
            inventory.RestockItem("SKU001", 10);

            Console.WriteLine("SKU001 restocked successfully.");

            // Successful Sale

            Console.WriteLine("\n===== SUCCESSFUL SALE =====");

            try
            {
                // Sell 5 units of SKU002.
                inventory.SellItem("SKU002", 5);

                Console.WriteLine("Sale completed successfully.");
            }
            catch (InsufficientStockException ex)
            {
                // Handle the custom exception.
                Console.WriteLine($"Sale failed: {ex.Message}");
            }

            // Attempted Oversell

            Console.WriteLine("\n===== ATTEMPTED OVERSELL =====");

            try
            {
                // SKU003 has only 5 units,
                // so trying to sell 50 will throw an exception.
                inventory.SellItem("SKU003", 50);
            }
            catch (InsufficientStockException ex)
            {
                // Catch and display the exception message.
                Console.WriteLine($"Sale failed: {ex.Message}");
            }

            // Missing SKU Test

            Console.WriteLine("\n===== MISSING SKU TEST =====");

            // UNKNOWN does not exist, so RestockItem creates it.
            inventory.RestockItem("UNKNOWN", 10);

            try
            {
                // UNKNOWN2 does not exist.
                // The method will throw our custom exception.
                inventory.SellItem("UNKNOWN2", 5);
            }
            catch (InsufficientStockException ex)
            {
                // Handle the missing SKU case gracefully.
                Console.WriteLine($"Sale failed: {ex.Message}");
            }

            // Low Stock Report

            Console.WriteLine("\n===== LOW STOCK REPORT =====");

            // Display all items with quantity below 10.
            inventory.LowStockReport(10);

            // Final Inventory

            Console.WriteLine("\n===== FINAL INVENTORY =====");

            // Display the inventory after all operations.
            inventory.DisplayInventory();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}