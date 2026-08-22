using System.Collections.Generic;

namespace Lab8_ComprehensiveMiniReport
{
    // Provides the product dataset used by the lab.
    public static class ProductData
    {
        // Creates and returns the shared product dataset.
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 75000, InStock = true },
                new Product { Id = 2, Name = "Smartphone", Category = "Electronics", Price = 45000, InStock = true },
                new Product { Id = 3, Name = "Headphones", Category = "Electronics", Price = 5000, InStock = false },
                new Product { Id = 4, Name = "Smart Watch", Category = "Electronics", Price = 12000, InStock = true },

                new Product { Id = 5, Name = "Office Chair", Category = "Furniture", Price = 8500, InStock = true },
                new Product { Id = 6, Name = "Study Table", Category = "Furniture", Price = 12000, InStock = true },
                new Product { Id = 7, Name = "Bookshelf", Category = "Furniture", Price = 7000, InStock = false },

                new Product { Id = 8, Name = "Rice Bag", Category = "Grocery", Price = 2500, InStock = true },
                new Product { Id = 9, Name = "Cooking Oil", Category = "Grocery", Price = 1800, InStock = true },
                new Product { Id = 10, Name = "Tea Pack", Category = "Grocery", Price = 900, InStock = true },

                new Product { Id = 11, Name = "Jacket", Category = "Clothing", Price = 6000, InStock = true },
                new Product { Id = 12, Name = "Jeans", Category = "Clothing", Price = 3500, InStock = false },
                new Product { Id = 13, Name = "T-Shirt", Category = "Clothing", Price = 1500, InStock = true }
            };
        }
    }
}