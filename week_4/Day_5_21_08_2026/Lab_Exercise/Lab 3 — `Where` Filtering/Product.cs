namespace Lab3WhereFiltering;

// Summary:
// Product class represents one product in our product list.
// It contains the basic information needed for LINQ filtering.
public class Product
{
    // Unique ID of the product.
    public int Id { get; set; }

    // Name of the product.
    public string Name { get; set; }

    // Category to which the product belongs.
    public string Category { get; set; }

    // Price of the product.
    public decimal Price { get; set; }

    // Indicates whether the product is currently in stock.
    public bool InStock { get; set; }
}