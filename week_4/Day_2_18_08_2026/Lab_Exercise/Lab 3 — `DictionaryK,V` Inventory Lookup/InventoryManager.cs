using System;
using System.Collections.Generic;

namespace InventoryLookup
{
    // Summary:
    // InventoryManager manages the inventory using Dictionary<string, int>.
    // The key represents the SKU and the value represents the quantity.
    public class InventoryManager
    {
        // Dictionary stores SKU codes as keys
        // and available quantities as values.
        private Dictionary<string, int> inventory;

        // Summary:
        // Constructor creates an empty dictionary for storing inventory data.
        public InventoryManager()
        {
            // Create the dictionary.
            inventory = new Dictionary<string, int>();
        }

        // Summary:
        // LoadSampleData adds at least 8 sample SKU records
        // to the inventory dictionary.
        public void LoadSampleData()
        {
            // Add sample SKU and quantity pairs.
            inventory.Add("SKU001", 20);
            inventory.Add("SKU002", 15);
            inventory.Add("SKU003", 5);
            inventory.Add("SKU004", 30);
            inventory.Add("SKU005", 8);
            inventory.Add("SKU006", 25);
            inventory.Add("SKU007", 3);
            inventory.Add("SKU008", 12);
        }

        // Summary:
        // RestockItem adds quantity to an existing SKU.
        // If the SKU does not exist, it creates a new entry.
        public void RestockItem(string sku, int quantity)
        {
            // Make sure the restock quantity is valid.
            if (quantity <= 0)
            {
                Console.WriteLine(
                    "Restock quantity must be greater than zero."
                );

                return;
            }

            // TryGetValue checks whether the SKU exists
            // and gets its current quantity.
            if (inventory.TryGetValue(sku, out int currentQuantity))
            {
                // Add the new quantity to the existing quantity.
                inventory[sku] = currentQuantity + quantity;
            }
            else
            {
                // If SKU does not exist, create a new entry.
                inventory[sku] = quantity;
            }
        }

        // Summary:
        // SellItem removes the requested quantity from the inventory.
        // It throws InsufficientStockException if the SKU is missing
        // or there is not enough stock.
        public void SellItem(string sku, int quantity)
        {
            // Make sure the sale quantity is valid.
            if (quantity <= 0)
            {
                Console.WriteLine(
                    "Sale quantity must be greater than zero."
                );

                return;
            }

            // Try to find the SKU and get its current quantity.
            if (!inventory.TryGetValue(sku, out int currentQuantity))
            {
                // SKU does not exist, so throw the custom exception.
                throw new InsufficientStockException(
                    $"SKU '{sku}' was not found in the inventory."
                );
            }

            // Check whether enough stock is available.
            if (currentQuantity < quantity)
            {
                // Not enough stock, so throw the custom exception.
                throw new InsufficientStockException(
                    $"Insufficient stock for '{sku}'. " +
                    $"Available: {currentQuantity}, " +
                    $"Requested: {quantity}."
                );
            }

            // Subtract the sold quantity from the current quantity.
            inventory[sku] = currentQuantity - quantity;
        }

        // Summary:
        // LowStockReport finds and displays all SKUs
        // whose quantity is below the specified threshold.
        public void LowStockReport(int threshold)
        {
            Console.WriteLine(
                $"Items with stock below {threshold}:"
            );

            // Used to check whether any low-stock item was found.
            bool found = false;

            // Iterate through every key-value pair in the dictionary.
            foreach (var item in inventory)
            {
                // item.Key contains the SKU.
                // item.Value contains the quantity.
                if (item.Value < threshold)
                {
                    Console.WriteLine(
                        $"SKU: {item.Key}, Quantity: {item.Value}"
                    );

                    // At least one low-stock item was found.
                    found = true;
                }
            }

            // Display a message if no low-stock items were found.
            if (!found)
            {
                Console.WriteLine("No low-stock items found.");
            }
        }

        // Summary:
        // DisplayInventory displays every SKU and its current quantity.
        public void DisplayInventory()
        {
            // Iterate through every dictionary entry.
            foreach (var item in inventory)
            {
                // Display the SKU and quantity.
                Console.WriteLine(
                    $"SKU: {item.Key}, Quantity: {item.Value}"
                );
            }
        }
    }
}