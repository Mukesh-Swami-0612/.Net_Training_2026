using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab7_DeferredImmediateExecution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Run the first experiment.
            DemonstrateDeferredExecution();

            // Run the second experiment.
            DemonstrateImmediateExecution();

            // Run the third experiment.
            DemonstrateDoubleEnumeration();


        }


        // Demonstrates that a deferred LINQ query sees changes
        // made to the original collection before enumeration.
        static void DemonstrateDeferredExecution()
        {
            Console.WriteLine("1. DEFERRED EXECUTION");


            // Get the original product list.
            List<Product> products = ProductData.GetProducts();

            // Build a Where query that selects products
            // with a price below Rs. 1000.
            //
            // IMPORTANT:
            // Where does not execute the filtering immediately.
            // It creates a query that will execute later.
            IEnumerable<Product> query =
                products.Where(p => p.Price < 1000);

            Console.WriteLine("\nQuery built.");
            Console.WriteLine("The query has not been enumerated yet.");

            // Add a new product AFTER the query was created.
            // This product matches the filter because its price is 700.
            products.Add(new Product
            {
                Id = 13,
                Name = "Notebook",
                Category = "Stationery",
                Price = 700,
                InStock = true
            });

            Console.WriteLine("\nNew product added to the original list:");
            Console.WriteLine("Notebook - Rs.700");

            Console.WriteLine("\nEnumerating the deferred query:");

            // The query actually executes here.
            // Because Notebook was added before enumeration,
            // it is included in the results.
            foreach (Product product in query)
            {
                Console.WriteLine(
                    $"{product.Name} - Rs.{product.Price}");
            }
        }


        // Demonstrates immediate execution using ToList().
        static void DemonstrateImmediateExecution()
        {
            Console.WriteLine("2. IMMEDIATE EXECUTION WITH ToList()");


            // Get a fresh product list.
            List<Product> products = ProductData.GetProducts();

            // Build the Where query and immediately execute it
            // by calling ToList().
            //
            // ToList() executes the query NOW and creates
            // a new list containing the current matching results.
            List<Product> snapshot =
                products
                    .Where(p => p.Price < 1000)
                    .ToList();

            Console.WriteLine("\nQuery executed immediately using ToList().");

            Console.WriteLine("Products in the snapshot before adding:");

            foreach (Product product in snapshot)
            {
                Console.WriteLine(
                    $"{product.Name} - Rs.{product.Price}");
            }

            // Add a new product to the ORIGINAL list.
            // It matches the Where condition.
            products.Add(new Product
            {
                Id = 14,
                Name = "Pen",
                Category = "Stationery",
                Price = 50,
                InStock = true
            });

            Console.WriteLine("\nNew product added to the original list:");
            Console.WriteLine("Pen - Rs.50");

            Console.WriteLine("\nSnapshot after adding the new product:");

            // Pen does NOT appear here because snapshot
            // was already created before Pen was added.
            foreach (Product product in snapshot)
            {
                Console.WriteLine(
                    $"{product.Name} - Rs.{product.Price}");
            }

            Console.WriteLine(
                "\nPen is not present because ToList() created a snapshot.");
        }


        // Demonstrates that a deferred query executes its predicate
        // again every time the query is enumerated.
        static void DemonstrateDoubleEnumeration()
        {
     
            Console.WriteLine("3. DOUBLE ENUMERATION");


            // Get a fresh product list.
            List<Product> products = ProductData.GetProducts();

            // Build a deferred Where query
            //
            // The Console.WriteLine inside the predicate allows
            // us to see when the filtering operation actually runs.
            IEnumerable<Product> expensiveQuery =
                products.Where(p =>
                {
                    Console.WriteLine(
                        $"Checking product: {p.Name}");

                    return p.Price < 2000;
                });

            Console.WriteLine("\nQuery built.");

            Console.WriteLine("\nFirst enumeration:");

            // First enumeration executes the predicate
            // for every product.
            foreach (Product product in expensiveQuery)
            {
                Console.WriteLine(
                    $"Result: {product.Name}");
            }

            Console.WriteLine("\nSecond enumeration:");

            // Second enumeration executes the predicate AGAIN.
            // This is the double-enumeration cost.
            foreach (Product product in expensiveQuery)
            {
                Console.WriteLine(
                    $"Result: {product.Name}");
            }

            Console.WriteLine("FIX: MATERIALIZE ONCE WITH ToList()");
           

            // Build the query again and immediately materialize it.
            //
            // The predicate executes once during ToList().
            List<Product> materializedResults =
                products
                    .Where(p =>
                    {
                        Console.WriteLine(
                            $"Checking product: {p.Name}");

                        return p.Price < 2000;
                    })
                    .ToList();

            Console.WriteLine("\nFirst enumeration of materialized list:");

            // This loop works with the already-created list.
            // The Where predicate does not run again.
            foreach (Product product in materializedResults)
            {
                Console.WriteLine(
                    $"Result: {product.Name}");
            }

            Console.WriteLine("\nSecond enumeration of materialized list:");

            // This loop also works with the existing list.
            // The original Where predicate does not execute again.
            foreach (Product product in materializedResults)
            {
                Console.WriteLine(
                    $"Result: {product.Name}");
            }

        }
    }
}