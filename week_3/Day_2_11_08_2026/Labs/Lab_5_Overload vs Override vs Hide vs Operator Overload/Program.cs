using System;

public class Program
{
    /// <summary>
    /// Main method where the program starts.
    /// Demonstrates overload, override, hide, and operator overload.
    /// </summary>
    public static void Main()
    {

        // 1. METHOD OVERLOADING

        Formatter formatter = new Formatter();

        Console.WriteLine(
            $"Format(7) -> \"{formatter.Format(7)}\""
        );

        Console.WriteLine(
            $"Format(3.5) -> \"{formatter.Format(3.5)}\""
        );

        Console.WriteLine(
            $"Format(3, 4) -> \"{formatter.Format(3, 4)}\""
        );


        Console.WriteLine();


        // 2. OVERRIDE VS HIDE       
        EmailNotifier emailNotifier = new EmailNotifier();

        // Notifier reference pointing to the same EmailNotifier object
        Notifier notifier = emailNotifier;


        Console.WriteLine("-- through EmailNotifier variable --");

        // Calls overridden Send()
        emailNotifier.Send();

        // Calls hidden Log()
        emailNotifier.Log();


        Console.WriteLine();


        Console.WriteLine(
            "-- through Notifier variable, same object --"
        );

        // Override: runtime object decides which method runs
        notifier.Send();

        // Hide: declared/reference type decides which method runs
        notifier.Log();


        Console.WriteLine();


        // 3. OPERATOR OVERLOADING

        Vector2 vector1 = new Vector2(1, 2);
        Vector2 vector2 = new Vector2(3, 4);

        // Uses overloaded + operator
        Vector2 sum = vector1 + vector2;

        Console.WriteLine(
            $"{vector1} + {vector2} = {sum}"
        );


        Vector2 vector3 = new Vector2(2, 2);

        // Uses overloaded * operator
        Vector2 scaled = vector3 * 3;

        Console.WriteLine(
            $"{vector3} * 3 = {scaled}"
        );
    }
}