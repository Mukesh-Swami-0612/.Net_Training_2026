using System;
using System.Collections.Generic;

class Program
{
    /// <summary>
    /// Finds the first petrol pump from which the truck
    /// can complete the circular tour.
    /// </summary>
   
    static int TruckTour(List<List<int>> petrolPumps)
    {
        // Stores the possible starting petrol pump index.
        int start = 0;

        // Stores the current petrol balance while travelling.
        int current = 0;

        // Stores the total petrol balance.
        int total = 0;

        // Traverse all petrol pumps.
        for (int i = 0; i < petrolPumps.Count; i++)
        {
            // Calculate the petrol remaining after reaching the next pump.
            int balance = petrolPumps[i][0] - petrolPumps[i][1];

            // Add the balance to the current petrol.
            current += balance;

            // Add the balance to the total petrol.
            total += balance;

            // If current petrol becomes negative,
            // the current starting point is invalid.
            if (current < 0)
            {
                // Choose the next pump as the new starting point.
                start = i + 1;

                // Reset the current petrol balance.
                current = 0;
            }
        }

        // Return the valid starting pump index.
        return start;
    }

    /// <summary>
    /// Entry point of the application.
    /// </summary>
    static void Main()
    {
        // Ask the user to enter the number of petrol pumps.
        Console.Write("Enter number of petrol pumps: ");

        // Read the number of petrol pumps.
        int n = Convert.ToInt32(Console.ReadLine());

        // Create a list to store petrol pump details.
        List<List<int>> petrolPumps = new();

        // Ask the user to enter petrol and distance values.
        Console.WriteLine("Enter Petrol and Distance:");

        // Read the details of each petrol pump.
        for (int i = 0; i < n; i++)
        {
            // Read one line of input and split it into two values.
            string[] input = Console.ReadLine().Split();

            // Store petrol and distance in the list.
            petrolPumps.Add(new List<int>
            {
                // Petrol available at the current pump.
                Convert.ToInt32(input[0]),

                // Distance to the next petrol pump.
                Convert.ToInt32(input[1])
            });
        }

        // Print a blank line for better formatting.
        Console.WriteLine();

        // Display the starting petrol pump index.
        Console.WriteLine("Starting Pump Index: " + TruckTour(petrolPumps));
    }
}