using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4OfType
{
    public class Program
    {
        // Main method is the starting point of the console application.
        public static void Main(string[] args)
        {
            // Run the first demonstration.
            DemonstrateBasicOfType();

            // Run the second demonstration.
            DemonstrateShapeOfType();

            // Run the third demonstration.
            DemonstrateOfTypeVsCast();


        }

        // Demonstrates OfType<T>() with a mixed List<object>.
        private static void DemonstrateBasicOfType()
        {
            Console.WriteLine();
            Console.WriteLine("1. OfType<T>() with Mixed Objects");

            // Create a list that can store different types.
            List<object> mixedItems = new List<object>
            {
                10,
                20,
                30,

                "Laptop",
                "Mouse",
                "Keyboard",

                10.5,
                20.75,
                30.25,

                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Category = "Electronics",
                    Price = 75000,
                    InStock = true
                },

                new Product
                {
                    Id = 2,
                    Name = "Mouse",
                    Category = "Electronics",
                    Price = 800,
                    InStock = true
                }
            };

            // OfType<int>() selects only integer values.
            IEnumerable<int> integers = mixedItems.OfType<int>();

            Console.WriteLine("Integers:");

            foreach (int number in integers)
            {
                Console.WriteLine(number);
            }

            // OfType<string>() selects only string values.
            IEnumerable<string> strings = mixedItems.OfType<string>();

            Console.WriteLine();
            Console.WriteLine("Strings:");

            foreach (string text in strings)
            {
                Console.WriteLine(text);
            }

            // OfType<Product>() selects only Product objects.
            IEnumerable<Product> products = mixedItems.OfType<Product>();

            Console.WriteLine();
            Console.WriteLine("Products:");

            foreach (Product product in products)
            {
                Console.WriteLine(
                    $"Id: {product.Id}, " +
                    $"Name: {product.Name}, " +
                    $"Price: Rs.{product.Price}"
                );
            }
        }

        // Demonstrates OfType<T>() with a Shape hierarchy.
        private static void DemonstrateShapeOfType()
        {
            Console.WriteLine();
            Console.WriteLine("2. OfType<T>() with Shape Hierarchy");


            // Create a list containing different Shape objects.
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Rectangle(10, 20),
                new Circle(3),
                new Rectangle(5, 8),
                new Circle(7),
                new Rectangle(12, 4)
            };

            // OfType<Circle>() selects only Circle objects.
            IEnumerable<Circle> circles = shapes.OfType<Circle>();

            // Calculate the total area of all circles.
            double totalCircleArea = circles.Sum(circle => circle.GetArea());

            Console.WriteLine(
                $"Total Circle Area: {totalCircleArea:F2}"
            );

            // OfType<Rectangle>() selects only Rectangle objects.
            IEnumerable<Rectangle> rectangles = shapes.OfType<Rectangle>();

            // Calculate the total area of all rectangles.
            double totalRectangleArea =
                rectangles.Sum(rectangle => rectangle.GetArea());

            Console.WriteLine(
                $"Total Rectangle Area: {totalRectangleArea:F2}"
            );
        }

        // Demonstrates the difference between OfType<T>() and Cast<T>().
        private static void DemonstrateOfTypeVsCast()
        {
            Console.WriteLine();
            Console.WriteLine("3. OfType<T>() vs Cast<T>()");

            // The list contains both Rectangle and Circle objects.
            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(10, 20),
                new Circle(5),
                new Rectangle(5, 8)
            };

            // OfType<Rectangle>() safely selects only rectangles.
            Console.WriteLine("Using OfType<Rectangle>():");

            IEnumerable<Rectangle> rectangles =
                shapes.OfType<Rectangle>();

            foreach (Rectangle rectangle in rectangles)
            {
                Console.WriteLine(
                    $"Rectangle: Width = {rectangle.Width}, " +
                    $"Height = {rectangle.Height}"
                );
            }

            // Cast<Rectangle>() assumes that every item is a Rectangle.
            // This assumption is false because the list contains a Circle.
            Console.WriteLine();
            Console.WriteLine("Using Cast<Rectangle>():");

            try
            {
                IEnumerable<Rectangle> castRectangles =
                    shapes.Cast<Rectangle>();

                foreach (Rectangle rectangle in castRectangles)
                {
                    Console.WriteLine(
                        $"Rectangle: Width = {rectangle.Width}, " +
                        $"Height = {rectangle.Height}"
                    );
                }
            }
            catch (InvalidCastException exception)
            {
                // The exception is caught so the application does not crash.
                Console.WriteLine(
                    "InvalidCastException caught."
                );

                Console.WriteLine(
                    $"Message: {exception.Message}"
                );
            }
        }
    }
}