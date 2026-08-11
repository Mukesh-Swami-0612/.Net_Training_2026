using System;

public struct RgbColor
{
    // RGB color values
    public byte R;
    public byte G;
    public byte B;

    /// <summary>
    /// Creates an RGB color using Red, Green, and Blue values.
    /// </summary>
    public RgbColor(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }

    /// <summary>
    /// Converts the RGB color into hexadecimal format.
    /// Example: #FF0000
    /// </summary>
    public override string ToString()
    {
        return $"#{R:X2}{G:X2}{B:X2}";
    }
}

// Enum containing some common named colors
public enum NamedColor
{
    Red,
    Green,
    Blue,
    White,
    Black
}

/// <summary>
/// Provides methods related to named colors.
/// </summary>
public static class ColorHelper
{
    /// <summary>
    /// Converts a NamedColor enum value into its RGB color.
    /// </summary>
    public static RgbColor FromNamed(NamedColor name)
    {
        switch (name)
        {
            case NamedColor.Red:
                return new RgbColor(255, 0, 0);

            case NamedColor.Green:
                return new RgbColor(0, 255, 0);

            case NamedColor.Blue:
                return new RgbColor(0, 0, 255);

            case NamedColor.White:
                return new RgbColor(255, 255, 255);

            case NamedColor.Black:
                return new RgbColor(0, 0, 0);

            default:
                return new RgbColor(0, 0, 0);
        }
    }
}