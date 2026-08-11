using System;
using System.Collections.Generic;

public class Program
{
    /// <summary>
    /// Main method where the program starts.
    /// Demonstrates shapes, polymorphism, overloading,
    /// and operator overloading.
    /// </summary>
    public static void Main()
    {
        // Create a list using the abstract Shape type
        List<Shape> shapes = new List<Shape>();


        // Add different types of shapes
        shapes.Add(new Circle(3));

        shapes.Add(new Rectangle(4, 6));

        shapes.Add(new Triangle(3, 4, 5));



        // POLYMORPHISM
        // Each object uses its own Area() and
        // Perimeter() implementation.
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape);
        }


        Console.WriteLine();


        // ----------------------------------------
        // TOTAL AREA
        // ----------------------------------------

        double totalArea = ShapeMath.TotalArea(shapes);

        Console.WriteLine(
            $"Total area (all shapes): {totalArea:F2}"
        );

        // TOTAL AREA OF CIRCLES


        double circleArea = ShapeMath.TotalArea(
            shapes,
            ShapeKind.Circle
        );

        Console.WriteLine(
            $"Total area (circles only): {circleArea:F2}"
        );


        Console.WriteLine();

        // BOUNDING BOX
        BoundingBox box = new BoundingBox(4, 3);

        // Uses overloaded * operator
        BoundingBox scaledBox = box * 2;

        Console.WriteLine(
            $"Scaled bounding box {box} * 2 -> {scaledBox}"
        );
    }
}