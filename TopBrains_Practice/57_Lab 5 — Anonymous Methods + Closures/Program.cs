using System;

namespace Lab5AnonymousMethodsClosures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects for both demonstrations.
            Lab5AnonymousMethods anonymousMethods = new Lab5AnonymousMethods();
            Lab5LambdaExpressions lambdaExpressions = new Lab5LambdaExpressions();


            // Run anonymous method examples.
            anonymousMethods.Run();

            Console.WriteLine();

            // Run lambda examples.
            lambdaExpressions.Run();

        }
    }
}