using System;
using System.Linq;

namespace Lab6_GroupByInto
{
    // Contains the main program and all four GroupBy demonstrations.
    public class Program
    {
        // Program entry point.
        public static void Main(string[] args)
        {
            var products = ProductData.GetProducts();

            // REPORT 1
            // Group products by Category and count products.
            Console.WriteLine("REPORT 1 - PRODUCTS GROUPED BY CATEGORY");

            var categoryGroups = products
                .GroupBy(p => p.Category);

            foreach (var group in categoryGroups)
            {
                Console.WriteLine(
                    $"Category: {group.Key}, Count: {group.Count()}");
            }

            // REPORT 2
            // Query syntax with into.
            // Keep categories having 3 or more products.
            // Order by total inventory value descending

            Console.WriteLine("REPORT 2 - GROUPING USING INTO");

            var filteredGroups =
                from product in products
                group product by product.Category into categoryGroup
                where categoryGroup.Count() >= 3
                orderby categoryGroup.Sum(p => p.Price) descending
                select categoryGroup;

            foreach (var group in filteredGroups)
            {
                Console.WriteLine(
                    $"Category: {group.Key}, " +
                    $"Count: {group.Count()}, " +
                    $"Total Value: {group.Sum(p => p.Price):C}");
            }


            // REPORT 3
            // Perform multiple aggregations on every category group.
            
            Console.WriteLine("REPORT 3 - CATEGORY AGGREGATIONS");
            

            foreach (var group in categoryGroups)
            {
                int count = group.Count();

                decimal totalValue = group.Sum(p => p.Price);

                decimal averagePrice = group.Average(p => p.Price);

                Product mostExpensiveProduct =
                    group.MaxBy(p => p.Price);

                Console.WriteLine($"Category: {group.Key}");
                Console.WriteLine($"Count: {count}");
                Console.WriteLine($"Total Value: {totalValue:C}");
                Console.WriteLine($"Average Price: {averagePrice:C}");
                Console.WriteLine(
                    $"Most Expensive Product: {mostExpensiveProduct.Name}");
                Console.WriteLine();
            }


            // REPORT 4
            // Group products using a composite key:
            // Category + InStock

            Console.WriteLine("REPORT 4 - COMPOSITE KEY GROUPING");


            var compositeGroups = products
                .GroupBy(p => new
                {
                    p.Category,
                    p.InStock
                });

            foreach (var group in compositeGroups)
            {
                Console.WriteLine(
                    $"Category: {group.Key.Category}, " +
                    $"InStock: {group.Key.InStock}, " +
                    $"Count: {group.Count()}");
            }
        }
    }
}