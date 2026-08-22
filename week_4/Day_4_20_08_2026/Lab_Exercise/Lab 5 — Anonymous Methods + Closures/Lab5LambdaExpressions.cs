using System;

namespace Lab5AnonymousMethodsClosures
{
    public class Lab5LambdaExpressions
    {
        // Demonstrates lambda expressions and closures.
        public void Run()
        {

            // PART 1: Lambda version of the square operation

            // Lambda syntax performs the same job as
            // the anonymous method from the previous class.

            Action<int> squareLambda = number =>
            {
                Console.WriteLine($"Square of {number} = {number * number}");
            };

            // Call the lambda.
            squareLambda(5);


            // PART 2: Lambda with a closure

            // Outer variable.
            int totalLambda = 0;

            // Lambda captures the outer variable.
            // This is also a closure.
            Action incrementLambda = () =>
            {
                totalLambda++;
            };

            // Call the lambda 5 times.
            incrementLambda();
            incrementLambda();
            incrementLambda();
            incrementLambda();
            incrementLambda();

            // The captured variable was modified.
            Console.WriteLine($"Lambda total = {totalLambda}");

            // Expected result:
            // Lambda total = 5
        }
    }
}