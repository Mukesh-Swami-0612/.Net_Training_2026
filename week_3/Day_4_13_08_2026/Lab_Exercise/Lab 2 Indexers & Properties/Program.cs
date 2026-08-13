using System;

public class Program
{
    public static void Main()
    {
        // Playlist

        Playlist playlist = new Playlist();

        playlist.Add("Song A");
        playlist.Add("Song B");
        playlist.Add("Song C");

        // Replace second song
        playlist[1] = "Song B (Replaced)";

        Console.Write("Playlist: ");

        for (int i = 0; i < playlist.Count; i++)
        {
            Console.Write(playlist[i]);

            if (i < playlist.Count - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
        Console.WriteLine();


        // TeamRoster

        TeamRoster roster = new TeamRoster();

        roster["Alice"] = 7;
        roster["Bob"] = 10;

        Console.WriteLine($"TeamRoster - Alice: {roster["Alice"]}");
        Console.WriteLine(
            $"TeamRoster - Zoe (not on roster): {roster["Zoe"]}"
        );

        Console.WriteLine();


        // Matrix

        Matrix matrix = new Matrix(3, 3);

        matrix[0, 0] = 1;
        matrix[0, 2] = 2;
        matrix[1, 1] = 5;
        matrix[2, 0] = 3;

        Console.WriteLine("Matrix:");

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matrix[row, col]);

                if (col < 2)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}