using System;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;

class Lab2
{
    // Build string using +=
    static string BuildWithString(int count)
    {
        string result = "";

        for (int i = 0; i < count; i++)
        {
            result += i.ToString();
        }

        return result;
    }

    // Build string using StringBuilder
    static string BuildWithStringBuilder(int count)
    {
        // Initial capacity to reduce memory reallocations
        StringBuilder result = new StringBuilder(count * 5);

        for (int i = 0; i < count; i++)
        {
            result.Append(i.ToString());
        }

        return result.ToString();
    }

    // Benchmark method
    static void RunBenchmark(int count)
    {
        Stopwatch stopwatch = new Stopwatch();

        // String concatenation
        stopwatch.Start();

        string stringResult = BuildWithString(count);

        stopwatch.Stop();

        long stringTime = stopwatch.ElapsedMilliseconds;

        // StringBuilder
        stopwatch.Restart();

        string stringBuilderResult = BuildWithStringBuilder(count);

        stopwatch.Stop();

        long stringBuilderTime = stopwatch.ElapsedMilliseconds;

        Console.WriteLine();
        Console.WriteLine($"===== Count: {count:N0} =====");

        Console.WriteLine(
            $"String concatenation ({count:N0} items): {stringTime} ms"
        );

        Console.WriteLine(
            $"StringBuilder ({count:N0} items): {stringBuilderTime} ms"
        );

        // Prevent division by zero
        if (stringBuilderTime > 0)
        {
            double ratio = (double)stringTime / stringBuilderTime;

            Console.WriteLine(
                $"String / StringBuilder ratio: {ratio:F2}x"
            );
        }
        else
        {
            Console.WriteLine(
                "StringBuilder completed too quickly to calculate ratio."
            );
        }
    }

    static void Main()
    {
        BuildWithString(1000);
        BuildWithStringBuilder(1000);

        // Benchmark 50,000
        RunBenchmark(50000);

        // Benchmark 200,000
        RunBenchmark(200000);
    }
}