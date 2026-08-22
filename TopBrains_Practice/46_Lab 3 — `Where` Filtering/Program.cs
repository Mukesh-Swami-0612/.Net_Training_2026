using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3WhereFiltering;

// Summary:
// Program class contains the Main method that demonstrates
// four different LINQ Where() filtering techniques.
public class Program
{
    // Summary:
    // Main method executes all four filtering examples
    // and prints the filtered products and their counts.
    public static void Main()
    {
        // Get the shared product dataset.
        List<Product> products = ProductData.GetProducts();
;

        // 1. Filter products under Rs.500

        // Where() keeps only products whose Price is less than 500.
        var productsUnder500 = products
            .Where(product => product.Price < 500)
            .ToList();

        Console.WriteLine("\n1. Products Under Rs.500");


        // Print every product returned by the filter.
        foreach (var product in productsUnder500)
        {
            Console.WriteLine(
                $"{product.Id} - {product.Name} - Rs.{product.Price}"
            );
        }

        // Print the number of matching products.
        Console.WriteLine($"Count: {productsUnder500.Count}");


        // 2. Filter products by category AND stock

        // We select products that:
        // 1. Belong to the Books category.
        // 2. Are currently in stock.
        var categoryAndInStock = products
            .Where(product =>
                product.Category == "Books" &&
                product.InStock)
            .ToList();

        Console.WriteLine("\n2. Books That Are In Stock");


        // Print every matching product.
        foreach (var product in categoryAndInStock)
        {
            Console.WriteLine(
                $"{product.Id} - {product.Name} - " +
                $"{product.Category} - In Stock: {product.InStock}"
            );
        }

        // Print the number of matching products.
        Console.WriteLine($"Count: {categoryAndInStock.Count}");


        // 3. Index-aware Where()

        // The second parameter of Where() gives us
        // the index of the current product.
        //
        // Index starts from 0:
        // 0, 1, 2, 3, 4, ...
        //
        // We select products at even indexes.
        var evenPositionProducts = products
            .Where((product, index) => index % 2 == 0)
            .ToList();

        Console.WriteLine("\n3. Products At Even Positions");

        // Print the products and their indexes.
        foreach (var item in evenPositionProducts)
        {
            int index = products.IndexOf(item);

            Console.WriteLine(
                $"Index {index} - {item.Name} - Rs.{item.Price}"
            );
        }

        // Print the number of matching products.
        Console.WriteLine($"Count: {evenPositionProducts.Count}");


        // 4. Compare two Where() calls vs one Where()

        // Approach A:
        // Use two separate Where() calls.
        var twoWhereCalls = products
            .Where(product => product.Category == "Books")
            .Where(product => product.InStock)
            .ToList();

        // Approach B:
        // Use one Where() call with &&.
        var oneWhereCall = products
            .Where(product =>
                product.Category == "Books" &&
                product.InStock)
            .ToList();

        Console.WriteLine("\n4. Two Where() Calls vs One Where() With &&");

        Console.WriteLine("\nUsing two Where() calls:");

        foreach (var product in twoWhereCalls)
        {
            Console.WriteLine(
                $"{product.Id} - {product.Name}"
            );
        }

        Console.WriteLine($"Count: {twoWhereCalls.Count}");

        Console.WriteLine("\nUsing one Where() with &&:");

        foreach (var product in oneWhereCall)
        {
            Console.WriteLine(
                $"{product.Id} - {product.Name}"
            );
        }

        Console.WriteLine($"Count: {oneWhereCall.Count}");

        // Compare both result collections.
        bool identical =
            twoWhereCalls.Count == oneWhereCall.Count &&
            twoWhereCalls
                .Select(product => product.Id)
                .SequenceEqual(
                    oneWhereCall.Select(product => product.Id)
                );

        Console.WriteLine(
            $"\nDo both approaches produce identical results? {identical}"
        );
    }
}