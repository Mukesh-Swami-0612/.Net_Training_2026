using System;

namespace Lab5AnonymousMethodsClosures
{
    public class Lab5AnonymousMethods
    {
        // Demonstrates anonymous methods and closures.
        public void Run()
        {


            // PART 1: Anonymous method for squaring a number

            // Action<int> accepts one int parameter
            // and returns nothing (void).
            //
            // The delegate keyword creates an anonymous method.
            Action<int> squareAnonymous = delegate (int number)
            {
                Console.WriteLine($"Square of {number} = {number * number}");
            };

            // Call the anonymous method.
            squareAnonymous(5);


            // PART 2: Anonymous method with a closure

            // This variable exists outside the anonymous method.
            int totalAnonymous = 0;

            // The anonymous method captures totalAnonymous.
            //
            // Because the method remembers the outer variable,
            // this is called a closure.
            Action incrementAnonymous = delegate
            {
                totalAnonymous++;
            };

            // Call the anonymous method 5 times.
            incrementAnonymous();
            incrementAnonymous();
            incrementAnonymous();
            incrementAnonymous();
            incrementAnonymous();

            // The outer variable has been modified.
            Console.WriteLine($"Anonymous method total = {totalAnonymous}");

            // Expected result:
            // Anonymous method total = 5
        }
    }
}