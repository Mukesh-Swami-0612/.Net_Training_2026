using System;

public class InventoryItem
{
    // Private backing field for Quantity
    private int _quantity;

    // Name can only be set during object creation
    public string Name { get; init; }

    // Quantity property with validation
    public int Quantity
    {
        get
        {
            return _quantity;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Quantity cannot be negative");
            }

            _quantity = value;
        }
    }

    // UnitPrice property with validation
    public decimal UnitPrice
    {
        get;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("UnitPrice must be greater than zero");
            }

            field = value;
        }
    }

    // Computed property - no backing field
    public decimal TotalValue
    {
        get
        {
            return Quantity * UnitPrice;
        }
    }

    // Constructor
    public InventoryItem(string name, int quantity, decimal unitPrice)
    {
        // Validate Name
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace");
        }

        // Assign through properties so validation runs
        Name = name;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
}