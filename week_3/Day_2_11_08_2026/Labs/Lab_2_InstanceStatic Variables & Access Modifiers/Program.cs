using System;

public class Program
{
    /// <summary>
    /// Main method where the program starts.
    /// Demonstrates static variables and access modifiers.
    /// </summary>
    public static void Main()
    {
        // Create first LibraryBook
        LibraryBook book1 = new LibraryBook(
            "C# Basics",
            "ISBN-001"
        );

        Console.WriteLine(
            $"Book 1 created. Total books so far: {LibraryBook.TotalBooksCreated}"
        );


        // Create second LibraryBook
        LibraryBook book2 = new LibraryBook(
            "ASP.NET Core",
            "ISBN-002"
        );

        Console.WriteLine(
            $"Book 2 created. Total books so far: {LibraryBook.TotalBooksCreated}"
        );


        // Create third LibraryBook
        LibraryBook book3 = new LibraryBook(
            "SQL Server",
            "ISBN-003"
        );

        Console.WriteLine(
            $"Book 3 created. Total books so far: {LibraryBook.TotalBooksCreated}"
        );


        Console.WriteLine();


        // Create a ReferenceBook
        ReferenceBook referenceBook = new ReferenceBook(
            "C# Reference",
            "ISBN-004"
        );

        // Demonstrate protected and private protected members
        referenceBook.PrintLocation();
    }
}