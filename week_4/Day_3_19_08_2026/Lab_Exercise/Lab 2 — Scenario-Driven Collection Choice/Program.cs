using System;

/// <summary>
/// Demonstrates the four collection choices from Lab 2.
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point of the application.
    /// </summary>
    public static void Main()
    {
        // ---------------------------------------------------------
        // 1. Undo Stack Demonstration
        // ---------------------------------------------------------

        Console.WriteLine("=== Undo Stack ===");

        // Create an UndoManager object.
        UndoManager undoManager = new();

        // Record some text editor actions.
        undoManager.RecordAction("Typed Hello");
        undoManager.RecordAction("Typed World");
        undoManager.RecordAction("Deleted World");

        // Undo returns the most recent action first.
        Console.WriteLine($"Undo: {undoManager.Undo()}");
        Console.WriteLine($"Undo: {undoManager.Undo()}");

        Console.WriteLine();

        // ---------------------------------------------------------
        // 2. Support Ticket Queue Demonstration
        // ---------------------------------------------------------

        Console.WriteLine("=== Support Ticket Queue ===");

        // Create a support ticket queue.
        SupportTicketQueue ticketQueue = new();

        // Submit customer tickets.
        ticketQueue.SubmitTicket("TICKET-001");
        ticketQueue.SubmitTicket("TICKET-002");
        ticketQueue.SubmitTicket("TICKET-003");

        // Process tickets in the order they arrived.
        Console.WriteLine($"Processing: {ticketQueue.ProcessNext()}");
        Console.WriteLine($"Processing: {ticketQueue.ProcessNext()}");

        Console.WriteLine();

        // ---------------------------------------------------------
        // 3. Unique Daily Active User Demonstration
        // ---------------------------------------------------------

        Console.WriteLine("=== Unique Daily Active Users ===");

        // Create a unique user tracker.
        DailyActiveUserTracker userTracker = new();

        // Record user visits.
        userTracker.RecordVisit(101);
        userTracker.RecordVisit(102);
        userTracker.RecordVisit(101);
        userTracker.RecordVisit(103);
        userTracker.RecordVisit(102);

        // Duplicate users are counted only once.
        Console.WriteLine(
            $"Unique visitors: {userTracker.UniqueVisitorCount()}");

        Console.WriteLine();

        // ---------------------------------------------------------
        // 4. Music Playlist Demonstration
        // ---------------------------------------------------------

        Console.WriteLine("=== Music Playlist ===");

        // Create a music playlist.
        MusicPlaylist playlist = new();

        // Add initial songs.
        playlist.Add("Song A");
        playlist.Add("Song B");
        playlist.Add("Song C");

        Console.WriteLine("Initial playlist:");
        playlist.Display();

        // Insert a new song after Song A.
        playlist.InsertAfter("Song A", "Song X");

        Console.WriteLine("After inserting Song X:");
        playlist.Display();

        // Remove Song B from the playlist.
        playlist.Remove("Song B");

        Console.WriteLine("After removing Song B:");
        playlist.Display();
    }
}