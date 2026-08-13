using System;

class Program
{
    static int SurfaceArea(int[,] A, int H, int W)
    {
        int area = 0;

        for (int i = 0; i < H; i++)
        {
            for (int j = 0; j < W; j++)
            {
                int current = A[i, j];

                if (current == 0)
                    continue;

                // Top and Bottom
                area += 2;

                // Up
                if (i == 0)
                    area += current;
                else
                    area += Math.Max(0, current - A[i - 1, j]);

                // Down
                if (i == H - 1)
                    area += current;
                else
                    area += Math.Max(0, current - A[i + 1, j]);

                // Left
                if (j == 0)
                    area += current;
                else
                    area += Math.Max(0, current - A[i, j - 1]);

                // Right
                if (j == W - 1)
                    area += current;
                else
                    area += Math.Max(0, current - A[i, j + 1]);
            }
        }

        return area;
    }

    static void Main()
    {
        // Input directly inside the code
        int H = 2;
        int W = 2;

        int[,] A =
        {
            { 1, 2 },
            { 3, 4 }
        };

        int result = SurfaceArea(A, H, W);

        Console.WriteLine("Surface Area = " + result);
    }
}