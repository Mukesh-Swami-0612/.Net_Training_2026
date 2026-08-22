using System.Collections.Generic;

namespace Lab5_OrderByThenBy
{
    // Provides the product data used by the lab.
    public static class ProductData
    {
        // Creates and returns the shared product dataset.
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 75000, InStock = true },
                new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 800, InStock = true },
                new Product { Id = 3, Name = "Keyboard", Category = "Electronics", Price = 1500, InStock = false },
                new Product { Id = 4, Name = "Monitor", Category = "Electronics", Price = 12000, InStock = true },

                new Product { Id = 5, Name = "Office Chair", Category = "Furniture", Price = 8500, InStock = true },
                new Product { Id = 6, Name = "Desk", Category = "Furniture", Price = 15000, InStock = false },
                new Product { Id = 7, Name = "Bookshelf", Category = "Furniture", Price = 7000, InStock = true },

                new Product { Id = 8, Name = "Notebook", Category = "Stationery", Price = 120, InStock = true },
                new Product { Id = 9, Name = "Pen", Category = "Stationery", Price = 50, InStock = false },
                new Product { Id = 10, Name = "Marker", Category = "Stationery", Price = 80, InStock = true },

                new Product { Id = 11, Name = "Water Bottle", Category = "Lifestyle", Price = 600, InStock = true },
                new Product { Id = 12, Name = "Backpack", Category = "Lifestyle", Price = 1800, InStock = false }
            };
        }
    }
}