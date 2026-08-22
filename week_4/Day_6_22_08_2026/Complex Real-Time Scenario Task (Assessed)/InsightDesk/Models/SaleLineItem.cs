namespace InsightDesk.Models;

/// <summary>
/// Represents one product line sold during the business day.
/// </summary>
public class SaleLineItem
{
    /// Gets or sets the unique identifier of the sale line.
    public int Id { get; set; }

    /// Gets or sets the product name.
    public string ProductName { get; set; } = string.Empty;

    /// Gets or sets the product category.
    public string Category { get; set; } = string.Empty;
    /// Gets or sets the price of one unit.
    public decimal UnitPrice { get; set; }
    /// Gets or sets the quantity sold.
    public int Quantity { get; set; }
    /// Gets or sets the staff member who handled the sale.
    public string StaffName { get; set; } = string.Empty;
    /// Gets or sets the store where the sale occurred.
    public string StoreLocation { get; set; } = string.Empty;
    /// Gets or sets the date and time of the sale.
    public DateTime SoldAt { get; set; }
    /// Gets the total value of this sale line.
    public decimal LineTotal => UnitPrice * Quantity;
}