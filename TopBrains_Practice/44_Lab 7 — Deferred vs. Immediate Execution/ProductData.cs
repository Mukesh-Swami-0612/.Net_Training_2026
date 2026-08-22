using System.Collections.Generic;

namespace Lab7_DeferredImmediateExecution
{
    // Provides the shared product dataset used by the lab.
    public static class ProductData
    {
        // Creates and returns the list of sample products.
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 75000, InStock = true },
                new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 1200, InStock = true },
                new Product { Id = 3, Name = "Keyboard", Category = "Electronics", Price = 2500, InStock = false },
                new Product { Id = 4, Name = "Monitor", Category = "Electronics", Price = 18000, InStock = true },

                new Product { Id = 5, Name = "Office Chair", Category = "Furniture", Price = 8500, InStock = true },
                new Product { Id = 6, Name = "Desk", Category = "Furniture", Price = 12000, InStock = false },
                new Product { Id = 7, Name = "Bookshelf", Category = "Furniture", Price = 6500, InStock = true },

                new Product { Id = 8, Name = "Rice", Category = "Grocery", Price = 800, InStock = true },
                new Product { Id = 9, Name = "Cooking Oil", Category = "Grocery", Price = 1600, InStock = true },
                new Product { Id = 10, Name = "Coffee", Category = "Grocery", Price = 450, InStock = false },

                new Product { Id = 11, Name = "T-Shirt", Category = "Clothing", Price = 900, InStock = true },
                new Product { Id = 12, Name = "Jeans", Category = "Clothing", Price = 2200, InStock = false }
            };
        }
    }
}