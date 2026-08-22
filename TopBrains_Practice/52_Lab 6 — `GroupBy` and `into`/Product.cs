namespace Lab6_GroupByInto
{
    // Represents one product in the product collection.
    public class Product
    {
        // Unique identifier of the product.
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
}