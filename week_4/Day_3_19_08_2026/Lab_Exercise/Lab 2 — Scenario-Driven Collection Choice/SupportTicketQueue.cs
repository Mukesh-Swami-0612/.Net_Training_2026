using System;
using System.Collections.Generic;

/// <summary>
/// Represents a customer support ticket system.
/// Queue is used because tickets are processed in arrival order.
/// </summary>
public class SupportTicketQueue
{
    // Queue stores support tickets.
    // One-line justification: Queue<T> is best because support tickets follow FIFO order.
    private readonly Queue<string> _tickets = new();

    /// <summary>
    /// Adds a new customer support ticket to the queue.
    /// </summary>
    public void SubmitTicket(string ticketId)
    {
        // Add the new ticket to the end of the queue.
        _tickets.Enqueue(ticketId);
    }

    /// <summary>
    /// Removes and returns the oldest unprocessed ticket.
    /// Returns null when there are no tickets.
    /// </summary>
    public string? ProcessNext()
    {
        // Check whether the queue contains any tickets.
        if (_tickets.Count == 0)
        {
            return null;
        }

        // Remove and return the oldest ticket.
        return _tickets.Dequeue();
    }
}