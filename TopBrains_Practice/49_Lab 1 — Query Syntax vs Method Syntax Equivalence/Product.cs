namespace Lab1LinqEquivalence;

public class Product
{
    // Unique ID of the product
    public int Id { get; set; }

    // Name of the product
    public string Name { get; set; }

    // Product category
    public string Category { get; set; }

    // Product price
    public decimal Price { get; set; }

    // Indicates whether the product is currently in stock
    public bool InStock { get; set; }
}