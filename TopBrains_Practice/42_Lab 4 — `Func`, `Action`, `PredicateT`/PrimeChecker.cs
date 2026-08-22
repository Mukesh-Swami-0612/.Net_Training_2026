using System;

namespace Lab4_GenericDelegates
{
    // PrimeChecker class contains logic for checking prime numbers.
    class PrimeChecker
    {
        // Determines whether a number is prime.
        public static bool IsPrime(int number)
        {
            // Numbers less than 2 are not prime.
            if (number < 2)
            {
                return false;
            }

            // Check whether the number is divisible
            // by any number from 2 up to its square root.
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            // If no divisor was found, the number is prime.
            return true;
        }
    }
}