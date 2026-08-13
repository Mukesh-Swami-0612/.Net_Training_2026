using System;

public class Program
{
    public static void Main()
    {
        // Create a valid InventoryItem
        InventoryItem item = new InventoryItem(
            "Keyboard",
            3,
            45.00m
        );

        // Display item details
        Console.WriteLine(
            $"Created: {item.Name}, Qty={item.Quantity}, " +
            $"Price=${item.UnitPrice:F2}, Total=${item.TotalValue:F2}"
        );

        // Try setting invalid Quantity
        try
        {
            item.Quantity = -5;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(
                $"Caught expected error setting Quantity=-5: {ex.Message}"
            );
        }

        // Try setting invalid UnitPrice
        try
        {
            item.UnitPrice = 0;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(
                $"Caught expected error setting UnitPrice=0: {ex.Message}"
            );
        }
    }
}