using System;
using System.Collections.Generic;

namespace Lab7_LoopVariableCapture
{
    class ForLoopDemo
    {
        // Run()
        // Runs both the buggy and corrected for-loop examples.
        public static void Run()
        {

            Console.WriteLine("PART 1: BUGGY FOR LOOP");
            BuggyForLoop();

            Console.WriteLine("PART 2: FIXED FOR LOOP");
    
            FixedForLoop();
        }

        // BuggyForLoop()
        // Creates Action delegates inside a for loop without
        // copying the loop variable.

        private static void BuggyForLoop()
        {
            List<Action> actions = new List<Action>();

            // The loop variable 'i' is captured by the lambdas.
            for (int i = 0; i < 3; i++)
            {
                actions.Add(() => Console.WriteLine(i));
            }

            Console.WriteLine("Output:");

            // The loop has already finished before the Actions
            // are executed.
            //
            // In this classic capture example, all delegates refer
            // to the captured loop variable, whose final value is 3.
            //
            // Actual output:
            // 3
            // 3
            // 3

            foreach (Action action in actions)
            {
                action();
            }

            Console.WriteLine();
            Console.WriteLine("Explanation:");
            Console.WriteLine(
                "All lambdas captured the same for-loop variable 'i'."
            );

            Console.WriteLine(
                "After the loop finishes, i has the value 3."
            );

            Console.WriteLine(
                "Therefore all three Actions print 3."
            );
        }


   
        // FixedForLoop()
        // Fixes the problem by copying the loop variable into
        // a new local variable inside each iteration.


        private static void FixedForLoop()
        {
            List<Action> actions = new List<Action>();

            for (int i = 0; i < 3; i++)
            {
                // Create a new local variable for this iteration.
                int index = i;

                // The lambda captures 'index', not 'i'.
                actions.Add(() => Console.WriteLine(index));
            }

            Console.WriteLine("Output:");

            // Each Action has its own captured 'index' variable.

            foreach (Action action in actions)
            {
                action();
            }

            Console.WriteLine();
            Console.WriteLine("Explanation:");

            Console.WriteLine(
                "A new local variable 'index' is created during every iteration."
            );

            Console.WriteLine(
                "Each lambda captures its own 'index' variable."
            );

            Console.WriteLine(
                "Therefore the Actions print 0, 1, and 2."
            );
        }
    }
}