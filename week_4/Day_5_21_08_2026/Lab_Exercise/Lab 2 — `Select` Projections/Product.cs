namespace Lab2SelectProjections;

public class Product
{
    // Unique ID of the product
    public int Id { get; set; }

    // Name of the product
    public string Name { get; set; }

    // Category to which the product belongs
    public string Category { get; set; }

    // Price of the product
    public decimal Price { get; set; }

    // Indicates whether the product is currently in stock
    public bool InStock { get; set; }
}