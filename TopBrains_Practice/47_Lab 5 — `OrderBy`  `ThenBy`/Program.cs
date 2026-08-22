using System;

namespace Lab5_OrderByThenBy
{
    // Main program class used to run the LINQ sorting demonstrations.
    public class Program
    {
        // Entry point of the console application.
        public static void Main(string[] args)
        {
            // Get the shared product dataset.
            var products = ProductData.GetProducts();


            // Display the first sorting example.
            Console.WriteLine("1. CATEGORY ASCENDING + PRICE DESCENDING");
            var categoryPriceSort =
                ProductSorter.SortByCategoryAndPrice(products);

            PrintProducts(categoryPriceSort);


            // Display the intentionally incorrect sorting.
            Console.WriteLine("2. BUGGY SORT: OrderBy + OrderBy");

            var buggySort =
                ProductSorter.BuggySort(products);

            PrintProducts(buggySort);


            // Explain why the buggy version is incorrect.
            Console.WriteLine();
            Console.WriteLine("Why is this buggy?");
            Console.WriteLine(
                "The second OrderBy() becomes the new primary sort,");
            Console.WriteLine(
                "so the previous Category ordering is lost.");


            // Display the corrected sorting.
            Console.WriteLine("3. FIXED SORT: OrderBy + ThenByDescending");

            var fixedSort =
                ProductSorter.FixedSort(products);

            PrintProducts(fixedSort);


            // Display the three-key sorting example.
            Console.WriteLine();
            Console.WriteLine("4. THREE-KEY SORT");

            var threeKeySort =
                ProductSorter.SortByThreeKeys(products);

            PrintProducts(threeKeySort);
        }


        // Prints product information in a readable format.
        private static void PrintProducts(
            System.Collections.Generic.IEnumerable<Product> products)
        {
            Console.WriteLine(
                $"{"ID",-4} {"Name",-15} {"Category",-15} {"Price",-12} {"InStock",-10}");


            // Print every product in the supplied sequence.
            foreach (var product in products)
            {
                Console.WriteLine(
                    $"{product.Id,-4} " +
                    $"{product.Name,-15} " +
                    $"{product.Category,-15} " +
                    $"{product.Price,-12:C} " +
                    $"{product.InStock,-10}");
            }
        }
    }
}