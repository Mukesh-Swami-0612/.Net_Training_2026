using System;

namespace Lab6Generics
{
    // Summary: Generic class that tracks minimum and maximum values efficiently.
    public class MinMaxTracker<T> where T : IComparable<T>
    {
        // Store the current minimum value.
        public T Min { get; private set; }

        // Store the current maximum value.
        public T Max { get; private set; }

        // Track whether the tracker already contains a value.
        private bool hasValue;

        // Summary: Adds a value and updates Min and Max without rescanning all values.
        public void Add(T value)
        {
            // If this is the first value, it becomes both Min and Max.
            if (!hasValue)
            {
                Min = value;
                Max = value;
                hasValue = true;

                return;
            }

            // Update Min when the new value is smaller.
            if (value.CompareTo(Min) < 0)
            {
                Min = value;
            }

            // Update Max when the new value is larger.
            if (value.CompareTo(Max) > 0)
            {
                Max = value;
            }
        }
    }
}