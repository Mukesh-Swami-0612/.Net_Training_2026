namespace Lab6Generics
{
    // Summary: Generic class that stores two values of possibly different types.
    public class Pair<TFirst, TSecond>
    {
        // Store the first value.
        public TFirst First { get; set; }

        // Store the second value.
        public TSecond Second { get; set; }

        // Summary: Initializes the Pair object with the first and second values.
        public Pair(TFirst first, TSecond second)
        {
            // Assign the first value.
            First = first;

            // Assign the second value.
            Second = second;
        }

        // Summary: Returns the Pair values in readable text format.
        public override string ToString()
        {
            // Return both values as a formatted string.
            return $"First: {First}, Second: {Second}";
        }
    }
}