using System;

class Program
{
    static void Main()
    {
        // ============================================
        // Part 1: Testing StringUtils
        // ============================================

        Console.WriteLine(
            $"IsPalindrome(\"racecar\") -> {StringUtils.IsPalindrome("racecar")}"
        );

        Console.WriteLine(
            $"Reverse(\"Hello\") -> {StringUtils.Reverse("Hello")}"
        );

        Console.WriteLine(
            $"WordCount(\"the quick brown fox\") -> {StringUtils.WordCount("the quick brown fox")}"
        );


        // Static classes cannot be instantiated.
        // The following line will NOT compile:
        //
        // StringUtils utils = new StringUtils();

        Console.WriteLine(
            "(new StringUtils() would not compile)"
        );


        // ============================================
        // Part 2: Testing TrackedWidget
        // ============================================

        TrackedWidget widget1 = new TrackedWidget();
        TrackedWidget widget2 = new TrackedWidget();
        TrackedWidget widget3 = new TrackedWidget();

        Console.WriteLine(
            $"LiveCount after creating 3 widgets: {TrackedWidget.LiveCount}"
        );

        widget1.PrintInfo();
        widget2.PrintInfo();
        widget3.PrintInfo();


        // Dispose two widgets
        widget1.Dispose();
        widget2.Dispose();

        Console.WriteLine(
            $"LiveCount after disposing 2: {TrackedWidget.LiveCount}"
        );
    }
}