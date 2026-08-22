namespace Lab1TypingDemo
{
    internal class AnonymousTypeDemo
    {
        // Run demonstrates how an anonymous type is created and used.
        public static void Run()
        {
            Console.WriteLine("----- Anonymous Type Demonstration -----");
            Console.WriteLine();

            // Create an anonymous type.
            // The compiler automatically creates a type containing
            // properties named X and Y.
            var point = new
            {
                X = 3,
                Y = 7
            };

            // Access and print the anonymous type properties.
            Console.WriteLine("Point X: " + point.X);
            Console.WriteLine("Point Y: " + point.Y);

            Console.WriteLine();

            // Anonymous type properties are read-only.
            // Therefore, the following statement causes a compiler error.

            // point.X = 10;

            // Compiler error:
            // Property 'X' cannot be assigned to because it is read-only.

            Console.WriteLine("Anonymous type properties are read-only.");
        }
    }
}