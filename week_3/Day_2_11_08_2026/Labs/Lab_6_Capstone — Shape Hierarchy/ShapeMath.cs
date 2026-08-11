using System.Collections.Generic;

public static class ShapeMath
{
    /// <summary>
    /// Calculates the total area of all shapes.
    /// </summary>
    public static double TotalArea(IEnumerable<Shape> shapes)
    {
        double total = 0;

        foreach (Shape shape in shapes)
        {
            total += shape.Area();
        }

        return total;
    }


    /// <summary>
    /// Calculates the total area of only shapes
    /// that match the given ShapeKind.
    /// </summary>
    public static double TotalArea(
        IEnumerable<Shape> shapes,
        ShapeKind onlyKind)
    {
        double total = 0;

        foreach (Shape shape in shapes)
        {
            if (shape.Kind == onlyKind)
            {
                total += shape.Area();
            }
        }

        return total;
    }
}