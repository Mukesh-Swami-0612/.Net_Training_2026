using System;

namespace Lab7_LoopVariableCapture
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAB 7: LOOP-VARIABLE CAPTURE PITFALL

            Console.WriteLine(" LAB 7 - LOOP-VARIABLE CAPTURE PITFALL");

            // PART 1 AND PART 2
            // Demonstrate for-loop bug and its fix.

            ForLoopDemo.Run();

            // PART 3
            // Demonstrate foreach-loop behavior.

            ForeachLoopDemo.Run();

        }
    }
}