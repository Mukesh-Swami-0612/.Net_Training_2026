using System;

namespace Lab4OfType
{
    // Base class for all shapes.
    public class Shape
    {
        // Shape is intentionally kept simple.
        // Circle and Rectangle inherit from this class.
    }

    // Circle inherits from Shape.
    public class Circle : Shape
    {
        // Radius of the circle.
        public double Radius { get; set; }

        // Constructor used to create a Circle with a radius.
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Calculates the area of the circle.
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle inherits from Shape.
    public class Rectangle : Shape
    {
        // Width of the rectangle.
        public double Width { get; set; }

        // Height of the rectangle.
        public double Height { get; set; }

        // Constructor used to create a Rectangle.
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Calculates the area of the rectangle.
        public double GetArea()
        {
            return Width * Height;
        }
    }
}