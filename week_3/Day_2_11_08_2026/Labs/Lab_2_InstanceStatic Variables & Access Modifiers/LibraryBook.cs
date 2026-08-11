using System;

public class LibraryBook
{
    // private: can only be accessed inside LibraryBook
    private string _isbn;

    // public: can be accessed from anywhere
    public string Title;

    // protected: can be accessed inside LibraryBook and derived classes
    protected string ShelfLocation = "Unassigned";

    // internal: can be accessed from anywhere in the same project/assembly
    internal int CopiesAvailable;

    // static: one shared variable for the whole class
    public static int TotalBooksCreated = 0;

    /// <summary>
    /// Creates a new library book and initializes its values.
    /// </summary>
    public LibraryBook(string title, string isbn)
    {
        Title = title;
        _isbn = isbn;

        // Every new book starts with one copy
        CopiesAvailable = 1;

        // Increase the shared book counter
        TotalBooksCreated++;
    }

    /// <summary>
    /// Changes the shelf location of the book.
    /// </summary>
    protected internal void Relocate(string newLocation)
    {
        ShelfLocation = newLocation;
    }

    /// <summary>
    /// Changes the number of available copies.
    /// </summary>
    private protected void AdjustCopies(int delta)
    {
        CopiesAvailable += delta;
    }
}


// Derived class
public class ReferenceBook : LibraryBook
{
    /// <summary>
    /// Creates a ReferenceBook using the LibraryBook constructor.
    /// </summary>
    public ReferenceBook(string title, string isbn)
        : base(title, isbn)
    {
    }

    /// <summary>
    /// Changes and displays the shelf location and number of copies.
    /// </summary>
    public void PrintLocation()
    {
        // ShelfLocation is protected,
        // so the derived class can access it.
        Relocate("Reference Section");

        Console.WriteLine(
            $"ReferenceBook shelf location after Relocate: \"{ShelfLocation}\""
        );

        // AdjustCopies is private protected.
        // It can also be accessed by this derived class.
        AdjustCopies(2);

        Console.WriteLine(
            $"Copies available after AdjustCopies(+2): {CopiesAvailable}"
        );
    }
}