using System;

public class Formatter
{
    /// <summary>
    /// Formats an integer value as text.
    /// </summary>
    public string Format(int number)
    {
        return number.ToString();
    }

    /// <summary>
    /// Formats a double value with two decimal places.
    /// </summary>
    public string Format(double number)
    {
        return number.ToString("F2");
    }

    /// <summary>
    /// Formats two integers as a fraction.
    /// </summary>
    public string Format(int numerator, int denominator)
    {
        return $"{numerator}/{denominator}";
    }
}


// Base class
public class Notifier
{
    /// <summary>
    /// Sends a generic notification.
    /// This method is virtual so a child class can override it.
    /// </summary>
    public virtual void Send()
    {
        Console.WriteLine("Notifier: generic send");
    }

    /// <summary>
    /// Writes a generic log message.
    /// This method is not virtual.
    /// </summary>
    public void Log()
    {
        Console.WriteLine("Notifier: generic log");
    }
}


// Derived class
public class EmailNotifier : Notifier
{
    /// <summary>
    /// Overrides Send() with email-specific behavior.
    /// </summary>
    public override void Send()
    {
        Console.WriteLine("EmailNotifier: sending email");
    }

    /// <summary>
    /// Hides the Log() method from the parent class.
    /// </summary>
    public new void Log()
    {
        Console.WriteLine("EmailNotifier: logging to email log");
    }
}


// Vector structure
public struct Vector2
{
    // X and Y represent the vector coordinates
    public double X;
    public double Y;

    /// <summary>
    /// Creates a Vector2 using X and Y values.
    /// </summary>
    public Vector2(double x, double y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Adds two Vector2 objects together.
    /// </summary>
    public static Vector2 operator +(Vector2 first, Vector2 second)
    {
        return new Vector2(
            first.X + second.X,
            first.Y + second.Y
        );
    }

    /// <summary>
    /// Multiplies a Vector2 by a scalar value.
    /// </summary>
    public static Vector2 operator *(Vector2 vector, double scalar)
    {
        return new Vector2(
            vector.X * scalar,
            vector.Y * scalar
        );
    }

    /// <summary>
    /// Converts the vector into readable text.
    /// </summary>
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}