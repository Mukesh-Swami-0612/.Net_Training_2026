using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8_ComprehensiveMiniReport
{
    // Contains the main program and LINQ demonstrations.
    public class Program
    {
        // Entry point of the console application.
        public static void Main()
        {
            // Load the shared product dataset.
            List<Product> products = ProductData.GetProducts();

            // Build the report using QUERY SYNTAX.

            var querySyntaxReport =
                from product in products

                // Keep only products that are currently in stock.
                where product.InStock

                // Group the remaining products by Category.
                group product by product.Category into categoryGroup

                // Sort the products inside each category by price descending.
                let orderedProducts = categoryGroup
                    .OrderByDescending(p => p.Price)
                    .ToList()

                // Create one summary object for each category.
                let summary = new CategorySummary
                {
                    // Store the category name.
                    Category = categoryGroup.Key,

                    // Count the in-stock products.
                    ItemCount = orderedProducts.Count,

                    // Calculate the total value of the category.
                    TotalValue = orderedProducts.Sum(p => p.Price),

                    // First product is the most expensive because
                    // the products were sorted by price descending.
                    TopProduct = orderedProducts.First().Name
                }

                // Sort categories by total category value descending.
                orderby summary.TotalValue descending

                // Return the final category summary.
                select summary;

            // Build the report using METHOD SYNTAX.

            var methodSyntaxReport = products

                // Keep only products that are in stock.
                .Where(p => p.InStock)

                // Group the products by Category.
                .GroupBy(p => p.Category)

                // Convert every category group into a CategorySummary.
                .Select(categoryGroup =>
                {
                    // Sort products inside the current category
                    // from highest price to lowest price.
                    var orderedProducts = categoryGroup
                        .OrderByDescending(p => p.Price)
                        .ToList();

                    // Create and return the summary for this category.
                    return new CategorySummary
                    {
                        // Store the category name.
                        Category = categoryGroup.Key,

                        // Count products in this category.
                        ItemCount = orderedProducts.Count,

                        // Calculate total category value.
                        TotalValue = orderedProducts.Sum(p => p.Price),

                        // The first item is the most expensive product.
                        TopProduct = orderedProducts.First().Name
                    };
                })

                // Sort categories by total value from highest to lowest.
                .OrderByDescending(summary => summary.TotalValue)

                // Execute the query and store the result.
                .ToList();

            // Print QUERY SYNTAX report.

            Console.WriteLine("QUERY SYNTAX REPORT");

            PrintReport(querySyntaxReport);

            // Print METHOD SYNTAX report.


            Console.WriteLine("METHOD SYNTAX REPORT");


            PrintReport(methodSyntaxReport);

            // Confirm that both reports contain the same information.

            bool reportsMatch = ReportsMatch(
                querySyntaxReport.ToList(),
                methodSyntaxReport
            );

            Console.WriteLine("COMPARISON");


            Console.WriteLine(
                reportsMatch
                    ? "Query syntax and method syntax produce matching results."
                    : "Query syntax and method syntax produce different results."
            );
        }

        // Prints the category summaries in a readable format.
        private static void PrintReport(
            IEnumerable<CategorySummary> report)
        {
            // Print every category summary.
            foreach (CategorySummary summary in report)
            {
                Console.WriteLine();
                Console.WriteLine($"Category     : {summary.Category}");
                Console.WriteLine($"Item Count   : {summary.ItemCount}");
                Console.WriteLine($"Total Value  : Rs.{summary.TotalValue:N2}");
                Console.WriteLine($"Top Product  : {summary.TopProduct}");

            }
        }

        // Compares the two reports and returns true when they match.
        private static bool ReportsMatch(
            List<CategorySummary> firstReport,
            List<CategorySummary> secondReport)
        {
            // First check whether both reports have the same number
            // of category summaries.
            if (firstReport.Count != secondReport.Count)
            {
                return false;
            }

            // Compare every summary at the same position.
            for (int i = 0; i < firstReport.Count; i++)
            {
                CategorySummary first = firstReport[i];
                CategorySummary second = secondReport[i];

                // Compare all important summary values.
                if (first.Category != second.Category ||
                    first.ItemCount != second.ItemCount ||
                    first.TotalValue != second.TotalValue ||
                    first.TopProduct != second.TopProduct)
                {
                    return false;
                }
            }

            // If no difference was found, both reports match.
            return true;
        }
    }
}