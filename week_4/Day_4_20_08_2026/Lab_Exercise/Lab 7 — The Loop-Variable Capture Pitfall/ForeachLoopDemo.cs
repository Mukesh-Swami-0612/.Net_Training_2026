using System;
using System.Collections.Generic;

namespace Lab7_LoopVariableCapture
{
    class ForeachLoopDemo
    {
        public static void Run()
        {
            Console.WriteLine("PART 3: FOREACH LOOP");
        

            ForeachLoopCapture();
        }

        // ForeachLoopCapture()
        // Creates Actions inside a foreach loop without manually
        // copying the iteration variable.

        private static void ForeachLoopCapture()
        {
            List<Action> actions = new List<Action>();

            int[] numbers = { 0, 1, 2 };

            // The foreach iteration variable is captured directly.
            foreach (int number in numbers)
            {
                actions.Add(() => Console.WriteLine(number));
            }

            Console.WriteLine("Output:");

    
            // Modern C# gives each foreach iteration its own
            // iteration variable for closure capture.

            foreach (Action action in actions)
            {
                action();
            }

            Console.WriteLine();
            Console.WriteLine("Explanation:");

            Console.WriteLine(
                "foreach handles the iteration variable differently from the classic for-loop capture."
            );

            Console.WriteLine(
                "Each iteration provides a separate variable for the lambda to capture."
            );

            Console.WriteLine(
                "Therefore the output is 0, 1, and 2 without a manual copy."
            );
        }
    }
}