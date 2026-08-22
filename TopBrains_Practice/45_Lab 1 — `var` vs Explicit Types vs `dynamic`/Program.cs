namespace Lab1TypingDemo
{
    internal class Program
    {
        // Main is the entry point of the console application.
        // It calls each demonstration method one by one.
        static void Main(string[] args)
        {

            Console.WriteLine();

            // Demonstrate var, explicit type and dynamic.
            TypeDemonstration.Run();

            Console.WriteLine();

            // Demonstrate anonymous types.
            AnonymousTypeDemo.Run();

            Console.WriteLine();

        }
    }
}