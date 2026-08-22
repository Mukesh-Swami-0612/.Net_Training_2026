using System;
using System.Collections.Generic;

namespace Lab6LambdaExpressions
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // TASK 1: Expression-bodied lambda


            // Func<double, double, double> means:
            // This lambda calculates rectangle area.
            Func<double, double, double> rectangleArea =
                (w, h) => w * h;

            double width = 10.5;
            double height = 5.0;

            double area = rectangleArea(width, height);

            Console.WriteLine($"Width  : {width}");
            Console.WriteLine($"Height : {height}");
            Console.WriteLine($"Area   : {area}");


            // TASK 2: Statement-bodied lambda


            // Create an Action<Order>.
            //
            // Action does not return a value.
            //
            // Because we have multiple statements inside the lambda,
            // we use { }.
            Action<Order> printReceipt = order =>
            {
                Console.WriteLine("  RECEIPT");
               

                Console.WriteLine($"Order ID : {order.OrderId}");
                Console.WriteLine($"Customer : {order.CustomerName}");


                // Print every item in the order.
                foreach (OrderItem item in order.Items)
                {
                    Console.WriteLine(
                        $"{item.ProductName,-15} " +
                        $"Qty: {item.Quantity,2} " +
                        $"Price: {item.UnitPrice,8:F2} " +
                        $"Total: {item.GetTotal(),8:F2}"
                    );
                }


                // Print final order total.
                Console.WriteLine($"TOTAL: {order.GetTotal():F2}");

            };

            // Create an order.
            Order order = new Order("ORD-1001", "Mukesh");

            // Add products to the order.
            order.AddItem(new OrderItem("Laptop", 65000, 1));
            order.AddItem(new OrderItem("Mouse", 1200, 2));
            order.AddItem(new OrderItem("Keyboard", 2500, 1));

            // Execute the statement-bodied lambda.
            printReceipt(order);



            // TASK 3: Sort products using lambda expressions

            Console.WriteLine();

            Console.WriteLine("TASK 3 - Lambda-Based Sorting");


            List<Product> products = CreateProducts();

            // Sort 1: Price ascending

            Console.WriteLine();
            Console.WriteLine("BEFORE PRICE ASCENDING SORT:");

            PrintProducts(products);

            // Compare the prices of two products.
            products.Sort((p1, p2) =>
                p1.Price.CompareTo(p2.Price));

            Console.WriteLine();
            Console.WriteLine("AFTER PRICE ASCENDING SORT:");

            PrintProducts(products);


            // Sort 2: Name descending

            Console.WriteLine();
            Console.WriteLine("BEFORE NAME DESCENDING SORT:");

            PrintProducts(products);

            // Compare product names and reverse the result
            // to get descending order.
            products.Sort((p1, p2) =>
                p2.Name.CompareTo(p1.Name));

            Console.WriteLine();
            Console.WriteLine("AFTER NAME DESCENDING SORT:");

            PrintProducts(products);


            // Sort 3: Discounted price

            Console.WriteLine();
            Console.WriteLine("BEFORE DISCOUNTED PRICE SORT:");

            PrintProducts(products);

            // Calculate discounted price for both products
            // and compare the results.
            products.Sort((p1, p2) =>
                p1.GetDiscountedPrice()
                  .CompareTo(p2.GetDiscountedPrice()));

            Console.WriteLine();
            Console.WriteLine("AFTER DISCOUNTED PRICE ASCENDING SORT:");

            PrintProducts(products);



            
            // TASK 4: Remove out-of-stock products
            Console.WriteLine("TASK 4 - RemoveAll with Predicate Lambda");

            // Create a fresh list so we can clearly demonstrate removal.
            List<Product> inventory = CreateProducts();

            Console.WriteLine();
            Console.WriteLine("BEFORE REMOVAL:");

            PrintProducts(inventory);

            // Remove every product where Stock == 0.
            //
            // p => p.Stock == 0
            //
            // means:
            // "For each product p, check whether its stock is zero."
            int removedCount = inventory.RemoveAll(
                p => p.Stock == 0
            );

            Console.WriteLine();
            Console.WriteLine($"Products removed: {removedCount}");

            Console.WriteLine();
            Console.WriteLine("AFTER REMOVING OUT-OF-STOCK PRODUCTS:");

            PrintProducts(inventory);

            



            Console.ReadKey();
        }


        private static List<Product> CreateProducts()
        {
            return new List<Product>
            {
                new Product("Laptop", 65000, 5, 10),
                new Product("Mouse", 1200, 0, 5),
                new Product("Keyboard", 2500, 8, 15),
                new Product("Monitor", 18000, 3, 20),
                new Product("Headphones", 3500, 0, 25)
            };
        }

        // Prints all products in the supplied list.


        private static void PrintProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}