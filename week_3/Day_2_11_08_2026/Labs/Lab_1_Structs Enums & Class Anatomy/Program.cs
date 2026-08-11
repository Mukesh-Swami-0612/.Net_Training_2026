using System;

public class Pixel
{
    // Pixel contains an RGB color
    public RgbColor Color;
}

public class Program
{
    /// <summary>
    /// Main method where the program starts.
    /// Demonstrates struct copy and class reference copy.
    /// </summary>
    public static void Main()
    {
        // STRUCT COPY

        Console.WriteLine("-- struct copy --");

        // Create a red color
        RgbColor a = ColorHelper.FromNamed(NamedColor.Red);

        // Copy the struct
        RgbColor b = a;

        // Change only b
        b.R = 1;

        // a and b are separate copies
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");

        Console.WriteLine();


        // CLASS / REFERENCE COPY

        Console.WriteLine("-- class/reference copy --");

        // Create first Pixel object
        Pixel p1 = new Pixel();

        // Set its color to green
        p1.Color = ColorHelper.FromNamed(NamedColor.Green);

        // Copy the reference
        Pixel p2 = p1;

        // Change p2's color
        p2.Color = new RgbColor(0, 255, 0);

        // Both p1 and p2 refer to the same Pixel object
        Console.WriteLine($"p1.Color = {p1.Color}");
        Console.WriteLine($"p2.Color = {p2.Color}");
    }
}