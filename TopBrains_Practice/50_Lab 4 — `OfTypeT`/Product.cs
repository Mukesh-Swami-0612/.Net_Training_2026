using System.Collections.Generic;

namespace Lab4OfType
{
    // Product represents a product in our application.
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
    }

    // ProductData contains the shared product dataset.
    public static class ProductData
    {
        // Returns a list containing 12 products.
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 75000, InStock = true },
                new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 800, InStock = true },
                new Product { Id = 3, Name = "Keyboard", Category = "Electronics", Price = 1500, InStock = false },
                new Product { Id = 4, Name = "Monitor", Category = "Electronics", Price = 15000, InStock = true },

                new Product { Id = 5, Name = "T-Shirt", Category = "Clothing", Price = 700, InStock = true },
                new Product { Id = 6, Name = "Jeans", Category = "Clothing", Price = 1800, InStock = false },
                new Product { Id = 7, Name = "Jacket", Category = "Clothing", Price = 3500, InStock = true },

                new Product { Id = 8, Name = "Running Shoes", Category = "Footwear", Price = 4200, InStock = true },
                new Product { Id = 9, Name = "Formal Shoes", Category = "Footwear", Price = 3000, InStock = false },

                new Product { Id = 10, Name = "Backpack", Category = "Accessories", Price = 2200, InStock = true },
                new Product { Id = 11, Name = "Wallet", Category = "Accessories", Price = 900, InStock = true },
                new Product { Id = 12, Name = "Watch", Category = "Accessories", Price = 5000, InStock = false }
            };
        }
    }
}