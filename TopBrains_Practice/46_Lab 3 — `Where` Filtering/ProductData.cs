using System.Collections.Generic;

namespace Lab3WhereFiltering;

// Provides the shared product dataset used by the lab.
public static class ProductData
{
    // Returns a list containing 12 products across different categories.
    public static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Wireless Mouse", Category = "Electronics", Price = 450, InStock = true },
            new Product { Id = 2, Name = "Keyboard", Category = "Electronics", Price = 750, InStock = true },
            new Product { Id = 3, Name = "USB Cable", Category = "Electronics", Price = 250, InStock = false },

            new Product { Id = 4, Name = "C# Programming", Category = "Books", Price = 600, InStock = true },
            new Product { Id = 5, Name = "LINQ Fundamentals", Category = "Books", Price = 350, InStock = true },
            new Product { Id = 6, Name = "ASP.NET Core Guide", Category = "Books", Price = 900, InStock = false },

            new Product { Id = 7, Name = "T-Shirt", Category = "Clothing", Price = 400, InStock = true },
            new Product { Id = 8, Name = "Jeans", Category = "Clothing", Price = 1200, InStock = true },
            new Product { Id = 9, Name = "Jacket", Category = "Clothing", Price = 1800, InStock = false },

            new Product { Id = 10, Name = "Coffee Mug", Category = "Home", Price = 300, InStock = true },
            new Product { Id = 11, Name = "Table Lamp", Category = "Home", Price = 850, InStock = false },
            new Product { Id = 12, Name = "Wall Clock", Category = "Home", Price = 500, InStock = true }
        };
    }
}