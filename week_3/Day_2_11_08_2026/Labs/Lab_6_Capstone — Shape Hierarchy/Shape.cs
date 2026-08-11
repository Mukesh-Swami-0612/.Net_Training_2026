using System;

public enum ShapeKind
{
    Circle,
    Rectangle,
    Triangle
}


// Abstract base class
public abstract class Shape
{
    // Stores what type of shape this is
    public ShapeKind Kind { get; protected set; }

    /// <summary>
    /// Calculates the area of the shape.
    /// Each child class provides its own calculation.
    /// </summary>
    public abstract double Area();

    /// <summary>
    /// Calculates the perimeter of the shape.
    /// Each child class provides its own calculation.
    /// </summary>
    public abstract double Perimeter();

    /// <summary>
    /// Returns the shape type, area, and perimeter as text.
    /// </summary>
    public override string ToString()
    {
        return $"{Kind}: Area={Area():F2}, Perimeter={Perimeter():F2}";
    }
}


// Circle class
public class Circle : Shape
{
    // Radius of the circle
    public double Radius { get; }

    /// <summary>
    /// Creates a circle using the given radius.
    /// </summary>
    public Circle(double radius)
    {
        Kind = ShapeKind.Circle;
        Radius = radius;
    }

    /// <summary>
    /// Calculates the area of the circle.
    /// Formula: π × r × r
    /// </summary>
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    /// <summary>
    /// Calculates the circumference of the circle.
    /// Formula: 2 × π × r
    /// </summary>
    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}


// Rectangle class
public class Rectangle : Shape
{
    // Width and height of rectangle
    public double Width { get; }
    public double Height { get; }

    /// <summary>
    /// Creates a rectangle using width and height.
    /// </summary>
    public Rectangle(double width, double height)
    {
        Kind = ShapeKind.Rectangle;

        Width = width;
        Height = height;
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// Formula: width × height
    /// </summary>
    public override double Area()
    {
        return Width * Height;
    }

    /// <summary>
    /// Calculates the perimeter of the rectangle.
    /// Formula: 2 × (width + height)
    /// </summary>
    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }
}


// Triangle class
public class Triangle : Shape
{
    // Three sides of the triangle
    public double A { get; }
    public double B { get; }
    public double C { get; }

    /// <summary>
    /// Creates a triangle using three side lengths.
    /// </summary>
    public Triangle(double a, double b, double c)
    {
        Kind = ShapeKind.Triangle;

        A = a;
        B = b;
        C = c;
    }

    /// <summary>
    /// Calculates the perimeter of the triangle.
    /// </summary>
    public override double Perimeter()
    {
        return A + B + C;
    }

    /// <summary>
    /// Calculates triangle area using Heron's formula.
    /// </summary>
    public override double Area()
    {
        // Calculate the semi-perimeter
        double s = Perimeter() / 2;

        // Heron's formula:
        // Area = √(s × (s-a) × (s-b) × (s-c))
        return Math.Sqrt(
            s * (s - A) * (s - B) * (s - C)
        );
    }
}


// BoundingBox is a struct because it represents
// a small value type containing width and height.
public struct BoundingBox
{
    public double Width;
    public double Height;

    /// <summary>
    /// Creates a bounding box using width and height.
    /// </summary>
    public BoundingBox(double width, double height)
    {
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Scales the width and height by the given factor.
    /// </summary>
    public static BoundingBox operator *(
        BoundingBox box,
        double factor)
    {
        return new BoundingBox(
            box.Width * factor,
            box.Height * factor
        );
    }

    /// <summary>
    /// Converts the bounding box to readable text.
    /// </summary>
    public override string ToString()
    {
        return $"({Width:0}, {Height:0})";
    }
}   