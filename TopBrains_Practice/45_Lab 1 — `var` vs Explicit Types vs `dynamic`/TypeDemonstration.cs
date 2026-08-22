namespace Lab1TypingDemo
{
    internal class TypeDemonstration
    {
        // Run demonstrates var, explicit types and dynamic.
        // It also demonstrates how dynamic can cause a runtime exception.
        public static void Run()
        {
            Console.WriteLine("----- var vs Explicit Type vs dynamic -----");
            Console.WriteLine();

            // 1. DECLARING THE SAME VALUE USING THREE APPROACHES

            // var:
            // C# determines the type automatically at compile time.
            var count = 10;

            // Explicit type:
            // We directly tell C# that this variable is an integer.
            int countExplicit = 10;

            // dynamic:
            // The type-related operations are resolved at runtime.
            dynamic countDynamic = 10;

            // Print the values.
            Console.WriteLine("Value of count: " + count);
            Console.WriteLine("Value of countExplicit: " + countExplicit);
            Console.WriteLine("Value of countDynamic: " + countDynamic);

            Console.WriteLine();

            // Print the runtime types.
            Console.WriteLine("Type of count: " + count.GetType());
            Console.WriteLine("Type of countExplicit: " + countExplicit.GetType());
            Console.WriteLine("Type of countDynamic: " + countDynamic.GetType());

            Console.WriteLine();

            // 2. CHANGING THE DYNAMIC VALUE

            Console.WriteLine("----- dynamic Runtime Behavior -----");

            // Originally countDynamic contained an integer.
            // Now we assign a string to the same dynamic variable.
            countDynamic = "now text";

            Console.WriteLine("New value of countDynamic: " + countDynamic);
            Console.WriteLine("New runtime type: " + countDynamic.GetType());

            Console.WriteLine();

            // ATTEMPT INVALID ARITHMETIC OPERATION

            try
            {
                // At runtime countDynamic contains a string.
                // Therefore, trying to perform arithmetic with 5
                // causes a runtime binding exception.

                var result = countDynamic + 5;

                Console.WriteLine("Result: " + result);
            }
            catch (Exception ex)
            {
                // The exception is caught so that the application
                // does not terminate/crash.

                Console.WriteLine("Runtime exception caught!");
                Console.WriteLine("Exception type: " + ex.GetType().Name);
                Console.WriteLine("Exception message: " + ex.Message);
            }

            Console.WriteLine();

            
        }
    }
}