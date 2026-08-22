namespace Lab8_ComprehensiveMiniReport
{
    // Represents a single product in the product dataset.
    public class Product
    {
        // Stores the unique ID of the product.
        public int Id { get; set; }

        // Stores the name of the product.
        public string Name { get; set; }

        // Stores the category to which the product belongs.
        public string Category { get; set; }

        // Stores the price of the product.
        public decimal Price { get; set; }

        // Indicates whether the product is currently in stock.
        public bool InStock { get; set; }
    }
}