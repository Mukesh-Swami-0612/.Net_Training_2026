using System.Collections.Generic;

namespace Lab6_GroupByInto
{
    // Provides the shared product dataset used by the lab.
    public static class ProductData
    {
        // Creates and returns a list containing sample products.
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 75000, InStock = true },
                new Product { Id = 2, Name = "Smartphone", Category = "Electronics", Price = 45000, InStock = true },
                new Product { Id = 3, Name = "Headphones", Category = "Electronics", Price = 5000, InStock = false },
                new Product { Id = 4, Name = "Keyboard", Category = "Electronics", Price = 2500, InStock = true },

                new Product { Id = 5, Name = "Office Chair", Category = "Furniture", Price = 12000, InStock = true },
                new Product { Id = 6, Name = "Desk", Category = "Furniture", Price = 15000, InStock = false },
                new Product { Id = 7, Name = "Bookshelf", Category = "Furniture", Price = 8000, InStock = true },

                new Product { Id = 8, Name = "Notebook", Category = "Stationery", Price = 150, InStock = true },
                new Product { Id = 9, Name = "Pen Set", Category = "Stationery", Price = 300, InStock = true },
                new Product { Id = 10, Name = "Marker Pack", Category = "Stationery", Price = 450, InStock = false },
                new Product { Id = 11, Name = "Water Bottle", Category = "Stationery", Price = 600, InStock = true },

                new Product { Id = 12, Name = "Backpack", Category = "Accessories", Price = 2500, InStock = false },
                new Product { Id = 13, Name = "Wallet", Category = "Accessories", Price = 1200, InStock = true }
            };
        }
    }
}