using System;

namespace Lab4_GenericDelegates
{
    // Repeater class contains functionality for
    // executing an Action multiple times.
    class Repeater
    {
        // Executes the supplied Action the specified number of times.
        public static void Repeat(int times, Action action)
        {
            for (int i = 0; i < times; i++)
            {
                action();
            }
        }
    }
}