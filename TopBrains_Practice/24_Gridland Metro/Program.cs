using System;
using System.Collections.Generic;

class Result
{
    /*
     * This function calculates the number of cells
     * where lampposts can be installed.
     */
    public static long gridlandMetro(
        int n,
        int m,
        int k,
        List<List<int>> track)
    {
        // Dictionary stores tracks according to their row.
        //
        // Key   = row number
        // Value = list of tracks in that row
        Dictionary<int, List<List<int>>> rows =
            new Dictionary<int, List<List<int>>>();

        // Add every track to its row
        for (int i = 0; i < k; i++)
        {
            int row = track[i][0];
            int start = track[i][1];
            int end = track[i][2];

            // If this row is not already present
            if (!rows.ContainsKey(row))
            {
                rows[row] = new List<List<int>>();
            }

            // Add the track to that row
            rows[row].Add(new List<int> { start, end });
        }

        // Count how many cells are occupied by tracks
        long occupiedCells = 0;

        // Process every row that has tracks
        foreach (var row in rows)
        {
            List<List<int>> tracksInRow = row.Value;

            // Sort tracks according to starting column
            tracksInRow.Sort((a, b) => a[0].CompareTo(b[0]));

            // Start with the first track
            int currentStart = tracksInRow[0][0];
            int currentEnd = tracksInRow[0][1];

            // Check remaining tracks
            for (int i = 1; i < tracksInRow.Count; i++)
            {
                int nextStart = tracksInRow[i][0];
                int nextEnd = tracksInRow[i][1];

                // If tracks overlap or touch
                if (nextStart <= currentEnd + 1)
                {
                    // Extend the current track if necessary
                    if (nextEnd > currentEnd)
                    {
                        currentEnd = nextEnd;
                    }
                }
                else
                {
                    // No overlap
                    // Count the current track
                    occupiedCells += currentEnd - currentStart + 1;

                    // Start a new track
                    currentStart = nextStart;
                    currentEnd = nextEnd;
                }
            }

            // Count the final track
            occupiedCells += currentEnd - currentStart + 1;
        }

        // Total cells in the grid
        long totalCells = (long)n * m;

        // Free cells = total cells - occupied cells
        long freeCells = totalCells - occupiedCells;

        return freeCells;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        // INPUT
    
        int n = 4;
        int m = 4;
        int k = 3;

        List<List<int>> track = new List<List<int>>();

        // Track 1
        track.Add(new List<int> { 2, 2, 3 });

        // Track 2
        track.Add(new List<int> { 3, 1, 4 });

        // Track 3
        track.Add(new List<int> { 4, 4, 4 });


        
        // CALL FUNCTION
        long result = Result.gridlandMetro(n, m, k, track);

        // DISPLAY RESULT
        Console.WriteLine("Number of cells where lampposts can be placed:");
        Console.WriteLine(result);

        Console.ReadLine();
    }
}