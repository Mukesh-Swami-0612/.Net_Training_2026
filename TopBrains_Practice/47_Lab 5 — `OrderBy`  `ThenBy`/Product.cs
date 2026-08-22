namespace Lab5_OrderByThenBy
{
    // Represents one product in our product collection.
    public class Product
    {
        // Stores the unique ID of the product.
        public int Id { get; set; }

        // Stores the name of the product.
        public string Name { get; set; }

        // Stores the category of the product.
        public string Category { get; set; }

        // Stores the price of the product.
        public decimal Price { get; set; }

        // Stores whether the product is currently in stock.
        public bool InStock { get; set; }
    }
}