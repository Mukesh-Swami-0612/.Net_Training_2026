using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2SelectProjections;

public class Program
{
    public static void Main()
    {
        // Shared product dataset

        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Keyboard", Category = "Electronics", Price = 999m, InStock = true },
            new Product { Id = 2, Name = "Mouse", Category = "Electronics", Price = 599m, InStock = true },
            new Product { Id = 3, Name = "Monitor", Category = "Electronics", Price = 12500m, InStock = true },
            new Product { Id = 4, Name = "Headphones", Category = "Electronics", Price = 2499m, InStock = false },

            new Product { Id = 5, Name = "Office Chair", Category = "Furniture", Price = 8500m, InStock = true },
            new Product { Id = 6, Name = "Desk", Category = "Furniture", Price = 12000m, InStock = true },
            new Product { Id = 7, Name = "Bookshelf", Category = "Furniture", Price = 6500m, InStock = false },

            new Product { Id = 8, Name = "Notebook", Category = "Stationery", Price = 120m, InStock = true },
            new Product { Id = 9, Name = "Pen Set", Category = "Stationery", Price = 250m, InStock = true },
            new Product { Id = 10, Name = "File Folder", Category = "Stationery", Price = 180m, InStock = false },

            new Product { Id = 11, Name = "Backpack", Category = "Accessories", Price = 1999m, InStock = true },
            new Product { Id = 12, Name = "Water Bottle", Category = "Accessories", Price = 799m, InStock = false }
        };


        // 1. Select only product names

        IEnumerable<string> productNames = products
            .Select(p => p.Name);

        Console.WriteLine("1. Product Names");
        Console.WriteLine("----------------");

        foreach (string name in productNames)
        {
            Console.WriteLine(name);
        }


        // 2. Select an anonymous type with Name and PriceWithTax

        var productsWithTax = products
            .Select(p => new
            {
                // Copy the product name
                Name = p.Name,

                // Calculate price after adding 18% tax
                PriceWithTax = p.Price * 1.18m
            });

        Console.WriteLine("\n2. Products With 18% Tax");


        foreach (var product in productsWithTax)
        {
            Console.WriteLine(
                $"{product.Name} - Rs.{product.PriceWithTax:F2}"
            );
        }


        // 3. Select into ProductSummaryDto

        IEnumerable<ProductSummaryDto> summaries = products
            .Select(p => new ProductSummaryDto
            {
                // Copy the product name
                Name = p.Name,

                // Convert the price into a formatted string
                PriceLabel = $"Rs.{p.Price:F2}"
            });

        Console.WriteLine("\n3. Product Summary DTO");

        foreach (ProductSummaryDto summary in summaries)
        {
            Console.WriteLine(
                $"{summary.Name} - {summary.PriceLabel}"
            );
        }


        // 4. Index-aware Select

        IEnumerable<string> indexedProducts = products
            .Select((p, index) =>
                $"#{index + 1}: {p.Name}"
            );

        Console.WriteLine("\n4. Index-Aware Product List");

        foreach (string product in indexedProducts)
        {
            Console.WriteLine(product);
        }
    }
}